using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.ViewModels;
using PetShelter.Controllers;
using PetShelter.Shared.Services.Contracts;

namespace PetShelterMVC2.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin")]
    public class UserController : BaseCrudController<UserDto, IUserRepository, IUserService, UserEditVM, UserDetailsVM>
    {
        public UserController(IUserService service, IMapper mapper) : base(service, mapper)
        {

        }
    }
}
