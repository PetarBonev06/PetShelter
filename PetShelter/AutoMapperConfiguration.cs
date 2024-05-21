using AutoMapper;
using PetShelter.Data.Entities;
using PetShelter.Shared.Dtos;
using PetShelter.ViewModels;

namespace PetShelter
{
    internal class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<Breed, BreedDto>().ReverseMap();
            CreateMap<BreedDto, BreedEditVM>().ReverseMap();
            CreateMap<BreedDto, BreedDetailsVM>().ReverseMap();
        }
    }
}
