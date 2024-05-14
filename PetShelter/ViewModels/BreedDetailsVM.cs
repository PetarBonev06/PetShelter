﻿using PetShelter.Shared.Enums;
using System.Collections.Generic;

namespace PetShelter.ViewModels
{
    public class BreedDetailsVM : BaseVm
    {
        public string Name {  get; set; }

        public BreedSize Size { get; set; }

        public List<PetDetailsVM> Pets { get; set; }

    }
}
