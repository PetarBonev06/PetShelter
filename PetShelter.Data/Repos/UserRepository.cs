using AutoMapper;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;

namespace PetShelter.Data.Repos
{
    [AutoBind]
    public class UserRepository : BaseRepository<User, UserDto>, IUserRepository
    {
        public UserRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
