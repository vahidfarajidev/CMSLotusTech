using AutoMapper;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Application.Core.Datas.Queries.QueryModels;
using Domain.Core.Datas.Models;
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
            CreateMap<Data, DataEntity>().ReverseMap();

            CreateMap<DataEntity, DataQueryModel>();

        }
    }
}
