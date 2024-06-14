using Microsoft.Graph;
using PetShelter.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using User = PetShelter.Data.Entities.User;

namespace PetShelter.ViewModels
{
    public class PetDetailsVM : BaseVm
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        [DisplayName("Adopted")]
        public bool IsAdopted { get; set; }

        [DisplayName("Euthanized")]
        public bool IsEuthanized { get; set; }

        public int PetTypeId { get; set; }

        public PetTypeDetailsVM PetType { get; set; }

        public int BreedId { get; set; }

        public BreedDetailsVM Breed { get; set; }

        public int? AdopterId { get; set; }

        public UserDetailsVM Adopter { get; set; }

        public int? GiverId { get; set; }

        public UserDetailsVM Giver { get; set; }

        public int? ShelterId { get; set; }

        public ShelterDetailsVM Shelter { get; set; }

        public List<PetVaccineDetailsVM> PetVaccines { get; set; }

    }
}
