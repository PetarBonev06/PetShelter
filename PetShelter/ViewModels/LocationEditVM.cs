using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class LocationEditVM : BaseVm
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Address {  get; set; }
        [Required]
        public string Country { get; set; }
    }
}
