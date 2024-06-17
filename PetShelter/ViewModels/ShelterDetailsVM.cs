using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Graph;
using PetShelter.Data.Entities;
using System.Buffers.Text;
using System.Collections.Generic;
using Location = PetShelter.Data.Entities.Location;
using User = PetShelter.Data.Entities.User;

namespace PetShelter.ViewModels
{
    public class ShelterDetailsVM : BaseVm
    {
        public int PetCapacity { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        public virtual List<User> Employees { get; set; }

        public virtual List<Pet> Pets { get; set; }
        public IEnumerable<SelectListItem> LocationList { get; set; }

    }
}
