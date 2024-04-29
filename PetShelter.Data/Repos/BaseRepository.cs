using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OfficeDevPnP.Core.Framework.Provisioning.Model;
using PetShelter.Data.Entities;
using PetShelter.Shared.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShelter.Data.Repos
{
    public abstract class BaseRepository<T, TModel> : IBaseRepository<TModel>, IDisposable
        where T : BaseEntity
        where TModel : BaseModel
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        protected readonly IMapper mapper;
        private bool disposedValue;

        protected BaseRepository(PetShelterDbContext context, IMapper mapper)
        {
            _context = context;
            _dbSet = _context.Set<T>();
            this.mapper = mapper;
        }
        public virtual TModel MapToModel(T entity)
        {
            return mapper.Map<TModel>(entity);
        }
        public virtual T MapToEntity(TModel model)
        {
            return mapper.Map<T>(model);
        }
        public virtual IEnumerable<TModel> MapToEnumerableOfModel(IEnumerable<T> entites)
        {
            return mapper.Map<IEnumerable<TModel>>(entites);
        }
    }
    
}
