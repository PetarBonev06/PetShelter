﻿using Microsoft.Graph;
using PetShelter.Data.Entities;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class PetVaccineDetailsVM : BaseVm
    {
        public int PetId { get; set; }

        public virtual Pet Pet { get; set; }

        public int VaccineId { get; set; }

        public virtual Vaccine Vaccine { get; set; }

        public List<PetDetailsVM> Pets { get; set; }
    }
}

