using Microsoft.Graph;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class ShelterDetailsVM : BaseVm
    {
        public ShelterDetailsVM()
        {
            this.Pets = new List<PetDetailsVM>();
            this.Employees = new List<UserDetailsVM>();
        }
        public int PetCapacity {  get; set; }

        public int LocationId { get; set; }

        public List<UserDetailsVM> Employees { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
    }
}
