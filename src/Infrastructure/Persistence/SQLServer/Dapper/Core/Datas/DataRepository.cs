using AutoMapper;
using Domain.Core.Datas.Models;
using Domain.Core.Datas;
using Infrastructure.Persistence.SQLServer.Dapper.Base;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.Datas
{
    public class DataRepository : BaseRepository<Data, DataEntity>, IDataRepository
    {
        public DataRepository(DapperContext dapperContext, IMapper mapper) : base(dapperContext, mapper)
        {

        }
    }
}
