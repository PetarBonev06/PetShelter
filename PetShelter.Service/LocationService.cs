﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Service
{
    public class BreedsService : BaseCrudService<BreedDto, IBreedRepository>, IBreedService
    {
        public BreedsService(IBreedRepository repository) : base(repository)
        {

        }
    }
}
