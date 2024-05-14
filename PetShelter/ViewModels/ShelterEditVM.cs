using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class ShelterEditVM : BaseVm
    {
        [Required]
        public int PetCapacity { get; set; }

        [Required]
        [DisplayName("Location")]

        public int LocationId {  get; set; }

        public IEnumerable<SelectListItem> LocationsList { get; set; }

    }
}
