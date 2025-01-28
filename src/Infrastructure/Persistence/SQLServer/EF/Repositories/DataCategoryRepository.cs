using AutoMapper;
using Domain.DataCategories.Models;
using Domain.DataCategories.Repositories;
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
    public class DataCategoryRepository : IDataCategoryRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public DataCategoryRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task AddAsync(DataCategory entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DataCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DataCategory?> GetByIdAsync(Guid id)
        {
            var dataCategoryEntity = await _dbContext.Set<DataCategoryEntity>().FirstOrDefaultAsync(dc => dc.Id.Equals(id));
            return _mapper.Map<DataCategory>(dataCategoryEntity);
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return (await _dbContext.DataCategories.FirstOrDefaultAsync(dc => dc.Id == id)) != null;
        }

        public Task UpdateAsync(DataCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
