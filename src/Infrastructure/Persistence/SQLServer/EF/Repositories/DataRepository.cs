using AutoMapper;
using Domain.Core.Datas;
using Domain.Core.Datas.Models;
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
    public class DataRepository : BaseRepository<Data, DataEntity>, IDataRepository
    {

        public DataRepository(EFDbContext efDbContext, IMapper mapper) : base(efDbContext, mapper)
        {

        }

        public async Task<Data> GetDataByIdTestAsync(Guid id, CancellationToken cancellationToken)
        {
            var dataEntity = await _efDbContext.Set<DataEntity>().FirstOrDefaultAsync(d => d.Id.Equals(id), cancellationToken);

            return _mapper.Map<Data>(dataEntity);
        }
    }   
}
