using AutoMapper;
using Domain.Datas.Models;
using Domain.DataCategories.Models;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Application.Datas.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.MappingProfiles
{

    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<DataCategory, DataCategoryEntity>().ReverseMap();
            CreateMap<Data, DataEntity>().ReverseMap();

            CreateMap<DataEntity, DataQueryModel>();

        }
    }
}
