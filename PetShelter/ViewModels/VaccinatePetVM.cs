using Microsoft.AspNetCore.Mvc.Rendering;
using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class VaccinatePetVM
    {
        public int PetId { get; set; }

        public int VaccineId { get; set; }

        public IEnumerable<SelectListItem> VaccineList { get; set; }
    }
}
