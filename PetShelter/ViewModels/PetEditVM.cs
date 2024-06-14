using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class PetEditVM : BaseVm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public bool IsAdopted { get; set; }
        [Required]
        public bool IsEuthanized { get; set; }
        [Required]
        [DisplayName("Pet Type")]
        public int PetTypeId { get; set; }

        public IEnumerable<SelectListItem> PetTypeList { get; set; }
        [Required]
        [DisplayName("Breed")]
        public int BreedId { get; set; }
        public IEnumerable<SelectListItem> BreedList { get; set; }



        [Required]
        [DisplayName("Shelter")]
        public int? ShelterId { get; set; }

        public IEnumerable<SelectListItem> ShelterList { get; set; }
    }
}
