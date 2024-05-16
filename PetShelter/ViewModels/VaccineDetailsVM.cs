using Microsoft.Graph;
using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class VaccineDetailsVM : BaseVm
    {
        public string Name { get; set; }

        public string Description { get; set; }
         
        public virtual List<PetVaccine> PetVaccines { get; set; }

        public virtual List<Pet> Pets { get; set; }
    }
}
