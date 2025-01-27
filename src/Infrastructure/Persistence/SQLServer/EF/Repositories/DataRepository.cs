using AutoMapper;
using Domain.DataCategories.Models;
using Domain.Datas.Models;
using Domain.Datas.Repositories;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public DataRepository(AppDbContext commandContext, IMapper mapper)
        {
            _dbContext = commandContext;
            _mapper = mapper;
        }

        public async Task AddAsync(Data data, CancellationToken cancellationToken)
        {
            var dataEntity = _mapper.Map<DataEntity>(data);

            await _dbContext.AddAsync(dataEntity);
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Data>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Data?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Data> GetDataByIdTestAsync(Guid id)
        {
            var dataEntity = await _dbContext.Set<DataEntity>().FirstOrDefaultAsync(d => d.Id.Equals(id));
            return _mapper.Map<Data>(dataEntity);
        }

        public Task<bool> ExistsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Data data)
        {
            throw new NotImplementedException();
        }
    }
}
