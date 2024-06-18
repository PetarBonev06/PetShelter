using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetShelter.Service;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services.Contracts;
using PetShelter.ViewModels;
using System.Threading.Tasks;
using PetShelter.Shared;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace PetShelter.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee, User")]
    public class PetController : BaseCrudController<PetDto, IPetRepository, IPetService, PetEditVM, PetDetailsVM>
    {
        protected readonly IPetTypeService _petTypeService;
        protected readonly IBreedsService _breedsService;
        protected readonly IShelterService _sheltersService;
        protected readonly IUserService _usersService;
        protected readonly IVaccineService _vaccinesService;

        public PetController(IPetService service, IMapper mapper, IPetTypeService petTypesService, IBreedsService breedsService, IShelterService sheltersService, IUserService usersService, IVaccineService vaccinesService) : base(service, mapper)
        {
            this._petTypeService = petTypesService;
            this._breedsService = breedsService;
            this._sheltersService = sheltersService;
            this._usersService = usersService;
            this._vaccinesService = vaccinesService;
        }
        protected override async Task<PetEditVM> PrePopulateVMAsync(PetEditVM editVM)
        {
            editVM.PetTypeList = (await _petTypeService.GetAllAsync())
            .Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));
            editVM.BreedList = (await _breedsService.GetAllAsync())
            .Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));
            editVM.ShelterList = (await _sheltersService.GetAllAsync())
                .Select(x => new SelectListItem($"{x.PetCapacity}", x.Id.ToString()));
            return editVM;
        }
        [HttpGet]
        public virtual async Task<IActionResult> GivePet()
        {
            var editVM = await PrePopulateVMAsync(new PetEditVM());
            return View(editVM);
        }
        [HttpPost]
        public virtual async Task<IActionResult> GivePet(PetEditVM editVM)
        {
            var errors = await Validate(editVM);
            if (errors != null)
            {
                return View(editVM);
            }
            string loggedUsername = User.FindFirst(ClaimTypes.Name)?.Value;
            var user = await this._usersService.GetByUsernameAsync(loggedUsername);
            var model = this._mapper.Map<PetDto>(editVM);
            await this._service.GivePetAsync(user.Id, model.ShelterId.Value, model);
            return await List();
        }
        [HttpGet]
        public virtual async Task<IActionResult> AdoptPet(int? id)
        {
            if (id == null)
            {
                return BadRequest(Constants.InvalidId);
            }
            string loggedUsername = User.FindFirst(ClaimTypes.Name)?.Value;
            var model = await this._service.GetByIdIfExistsAsync(id.Value);
            var user = await this._usersService.GetByUsernameAsync(loggedUsername);
            if (model == default)
            {
                return BadRequest(Constants.InvalidId);
            }
            await this._service.AdoptPetAsync(user.Id, id.Value);

            return await List();
        }
        [HttpGet]
        public virtual async Task<IActionResult> VaccinatePet(int? petId)
        {
            if (petId == null)
            {
                return BadRequest(Constants.InvalidId);
            }
            var model = await this._service.GetByIdIfExistsAsync(petId.Value);
            if (model == default)
            {
                return BadRequest(Constants.InvalidId);
            }
            var vaccinatedPet = new VaccinatePetVM();
            vaccinatedPet.PetId = petId.Value;
            vaccinatedPet.VaccineList = (await _vaccinesService.GetAllAsync())
                .Select(x => new SelectListItem($"{x.Name}", x.Id.ToString()));
            return View(vaccinatedPet);
        }
        [HttpPost]
        public virtual async Task<IActionResult> VaccinatePet(int id, VaccinatePetVM editVM)
        {
            await this._service.VaccinatePetAsync(editVM.PetId, editVM.VaccineId);
            return await List();    
        }
    }
}
