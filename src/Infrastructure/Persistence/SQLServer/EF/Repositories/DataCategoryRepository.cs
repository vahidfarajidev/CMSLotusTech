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
    public class DataCategoryRepository : BaseRepository<DataCategory, DataCategoryEntity>, IDataCategoryRepository
    {
        public DataCategoryRepository(EFDbContext efDbContext, IMapper mapper) : base(efDbContext, mapper)
        {

        }
    }
}
