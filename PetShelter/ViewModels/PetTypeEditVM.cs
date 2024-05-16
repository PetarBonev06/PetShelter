using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class PetTypeEditVM : BaseVm
    {
        [Required]
        public string Name { get; set; }
    }
}
