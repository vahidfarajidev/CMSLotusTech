using Application.Core.Datas.Queries.Dtos;
using Application.Core.Datas.Queries.QueryModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.Mappings
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<DataQueryModel, DataDto>();
        }
    }
}
