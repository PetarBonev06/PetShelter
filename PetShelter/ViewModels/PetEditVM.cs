using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class PetEditVM : BaseVm
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        public bool IsAdopted { get; set; }

        public bool IsEuthanized { get; set; }

        public int PetTypeId { get; set; }

        public int BreedId { get; set; }

        public int? AdopterId { get; set; }

        public int? GiverId { get; set; }

        public int? ShelterId { get; set; }

    }
}
