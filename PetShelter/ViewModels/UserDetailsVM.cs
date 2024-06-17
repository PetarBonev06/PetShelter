using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Graph;
using PetShelter.Data.Entities;
using System.Buffers.Text;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class UserDetailsVM : BaseVm
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }

        public int? ShelterId { get; set; }

        public virtual Shelter Shelter { get; set; }

        public virtual List<Pet> AdoptedPets { get; set; }

        public virtual List<Pet> GivenPets { get; set; }
        public virtual List<Pet> Pets { get; set; }
        public IEnumerable<SelectListItem> ShelterList { get; set; }

    }
}
