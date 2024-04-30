using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Service
{
    public class VaccineService : VaccineService<VaccineDto, IVaccineRepository>, IVaccineService
    {
        public VaccineService(IVaccineRepository repository) : base(repository)
        {

        }
    }
}
