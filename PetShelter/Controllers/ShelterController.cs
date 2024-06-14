using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Shared.Services;
using PetShelter.Shared.Services.Contracts;
using PetShelter.ViewModels;
using PetShelterMVC2.Controllers;
using System.Linq;
using System.Threading.Tasks;

namespace PetShelter.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin,Employee")]
    public class ShelterController : BaseCrudController<ShelterDto, IShelterRepository, IShelterService, ShelterEditVM, ShelterDetailsVM>
    {
        private readonly ILocationService _locationsService;
        public ShelterController(IShelterService service, IMapper mapper, ILocationService locationsService) : base(service, mapper)
        {
            _locationsService = locationsService;
        }

        protected override async Task<ShelterEditVM> PrePopulateVMAsync(ShelterEditVM editVM)
        {
            editVM.LocationsList = (await _locationsService.GetAllActiveAsync())
            .Select(x => new SelectListItem($"{x.Country},{x.City},{x.Address}", x.Id.ToString()));
          
            return editVM;
        }
    }
}