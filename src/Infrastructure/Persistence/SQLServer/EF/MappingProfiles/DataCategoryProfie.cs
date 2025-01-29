using AutoMapper;
using Domain.Core.DataCategories.Models;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.MappingProfiles
{
    public class DataCategoryProfie : Profile
    {
        public DataCategoryProfie() 
        {
            CreateMap<DataCategory, DataCategoryEntity>().ReverseMap();
        }
    }
}
