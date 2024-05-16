using System.ComponentModel.DataAnnotations;

namespace PetShelter.ViewModels
{
    public class RoleEditVM : BaseVm
    {
        [Required]
        public string Name { get; set; }
    }
}
