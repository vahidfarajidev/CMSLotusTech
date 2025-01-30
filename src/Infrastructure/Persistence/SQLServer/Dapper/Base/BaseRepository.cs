using AutoMapper;
using Dapper.Contrib.Extensions;
using Domain.Base;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Base
{
    public class BaseRepository<TModel, TEntity> : IRepository<TModel>
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;

        public BaseRepository(DapperContext dapperContext, IMapper mapper)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
        }

        public async Task AddAsync(TModel model, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<TEntity>(model);

            using (IDbConnection dbConnection = _dapperContext.CreateConnection())
            {
                await dbConnection.InsertAsync(entity);
            }
        }

        public Task DeleteAsync(TModel model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(Guid id, CancellationToken cancellationToken)
        {
            using (IDbConnection dbConnection = _dapperContext.CreateConnection())
            {
                var entity = await dbConnection.GetAsync<TEntity>(id);
                return entity != null;
            }
        }

        public Task<IEnumerable<TModel>> GetAllAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TModel model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
