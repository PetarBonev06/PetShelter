using AutoMapper;
using PetShelter.Shared.Dtos;
using PetShelter.Shared.Repos.Contracts;
using PetShelter.Data.Entities;
using PetShelter.Shared.Attributes;
using Microsoft.EntityFrameworkCore;

namespace PetShelter.Data.Repos
{
    [AutoBind]
    public class UserRepository : BaseRepository<User, UserDto>, IUserRepository
    {
        public UserRepository(PetShelterDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<bool> CanUserLoginAsync(string username, string password)
        {
            return await _dbSet.AnyAsync(u => u.Username == username && u.Password == password);
        }

        public async Task<UserDto> GetByUsernameAsync(string username)
        {
            return MapToModel(await _dbSet.FirstOrDefaultAsync(u => u.Username == username));
        }
    }
}
