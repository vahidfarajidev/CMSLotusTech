using Domain.Core.DataCategories.Models;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.DataCategories
{
    public class DataCategoryProfie : Profile
    {
        public DataCategoryProfie()
        {
            // It is used for adding Data, DataCategory
            CreateMap<DataCategory, DataCategoryEntity>();
        }
    }
}
