using Microsoft.Graph;
using PetShelter.Data.Entities;
using System.Collections.Generic;
using User = PetShelter.Data.Entities.User;

namespace PetShelter.ViewModels
{
    public class RoleDetailsVM : BaseVm
    {
        public string Name { get; set; }

        public virtual List<User> Users { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
