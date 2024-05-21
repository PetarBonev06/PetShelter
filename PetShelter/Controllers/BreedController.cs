﻿using AutoMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using PetShelter.Services;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.ViewModels;

namespace PetShelter.Controllers
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Admin, Employee")]
    public class BreedController : BaseCrudController<BreedDto, IBreedRepository, IBreedService, BreedEditVM, BreedDetailsVM>
    {
        public BreedController(IBreedService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
