using Microsoft.Graph;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class PetTypeDetailsVM : BaseVm
    {
        public string Name {  get; set; }

        public virtual List<PetDetailsVM> Pets { get; set; }
    }
}
