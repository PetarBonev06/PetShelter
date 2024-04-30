using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Service
{
    public class PetVaccineService : PetVaccineService<PetVaccineDto, IPetVaccineRepository>, IPetVaccineService
    {
        public PetVaccineService(IPetVaccineRepository repository) : base(repository)
        {

        }
    }
}
