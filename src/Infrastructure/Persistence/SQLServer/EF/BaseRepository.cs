using AutoMapper;
using Domain.Base;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF
{
    public class BaseRepository<TModel, TEntity> : IRepository<TModel>
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        protected readonly EFDbContext _efDbContext;
        protected readonly IMapper _mapper;

        public BaseRepository(EFDbContext efDbContext, IMapper mapper)
        {
            _efDbContext = efDbContext;
            _mapper = mapper;
        }

        public async Task AddAsync(TModel model, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(model);

            await _efDbContext.AddAsync(entity, cancellationToken);
        }

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken)
        {
            return (await _efDbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken)) != null;
        }

        public Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<TModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = await _efDbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);

            if (entity == null) return null;

            return _mapper.Map<TModel>(entity);
        }

        public Task UpdateAsync(TModel model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}