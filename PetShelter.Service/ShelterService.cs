using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Service
{
    public class ShelterService : ShelterService<ShelterDto, IShelterRepository>, IShelterService
    {
        public ShelterService(IShelterRepository repository) : base(repository)
        {

        }
    }
}
