﻿using AutoMapper;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    [AutoBind]
    public class PetRepository : BaseRepository<Pet, PetDto>, IPetRepository
    {
        private readonly IPetVaccineRepository _vaccinesRepository;
        public PetRepository(PetShelterDbContext context, IMapper mapper, IPetVaccineRepository vaccinesRepository) : base(context, mapper)
        {
            _vaccinesRepository = vaccinesRepository;
        }

        public async Task AdoptPetAsync(int userId, int petId)
        {
            var pet = await GetByIdIfExistsAsync(petId);
            pet.AdopterId = userId;
            pet.IsAdopted = true;
            await SaveAsync(pet);
        }

        public async Task GivePetAsync(int userId, int shelterId, PetDto pet)
        {
            pet.ShelterId = shelterId;
            pet.GiverId = userId;
            await SaveAsync(pet);
        }

        public async Task VaccinatePetAsync(int petId, int vaccineId)
        {
            var pv = new PetVaccineDto();
            pv.PetId = petId;
            pv.VaccineId = vaccineId;
            await _vaccinesRepository.SaveAsync(pv);
        }
    }
}
