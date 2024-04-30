﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Service
{
    public class PetTypeService : BaseCrudService<PetTypeDto, IPetTypeRepository>, IPetTypeService
    {
        public PetTypeService(IPetTypeRepository repository) : base(repository)
        {

        }
    }
}