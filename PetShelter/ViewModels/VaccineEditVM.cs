using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class VaccineEditVM : BaseVm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
