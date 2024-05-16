using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class UserEditVM : BaseVm
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? RoleId { get; set; }

        public int? ShelterId { get; set; }

        public IEnumerable<SelectListItem> RoleList { get; set; }

        public IEnumerable<SelectListItem> ShelterList { get; set; }
    }
}
