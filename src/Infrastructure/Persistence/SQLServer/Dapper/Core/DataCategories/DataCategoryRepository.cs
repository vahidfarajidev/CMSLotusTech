using AutoMapper;
using Domain.Base;
using Domain.Core.DataCategories;
using Domain.Core.DataCategories.Models;
using Infrastructure.Persistence.SQLServer.Dapper.Base;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.DataCategories
{
    public class DataCategoryRepository : BaseRepository<DataCategory, DataCategoryEntity>, IDataCategoryRepository
    {
        public DataCategoryRepository(DapperContext dapperContext, IMapper mapper) : base(dapperContext, mapper)
        {

        }
    }
}
