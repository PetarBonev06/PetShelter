using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Graph;
using System.Buffers.Text;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class LocationDetailsVM : BaseVm
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public int? ShelterId { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
        public IEnumerable<SelectListItem> ShelterList { get; set; }
    }
}

