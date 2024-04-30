using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Service
{
    public class PetService : BaseCrudService<PetDto, IPetRepository>, IPetService
    {
        public PetService(IPetRepository repository) : base(repository)
        {

        }
    }
}
