using AutoMapper;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Application.Core.Datas.Queries.GetDataById;
using Domain.Core.Datas.Models;
using Application.Core.Datas.Queries.GetDataViewById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Core.Datas
{

    public class DataProfile : Profile
    {
        public DataProfile()
        {
            // It is used for adding Data.
            CreateMap<Data, DataEntity>();

            CreateMap<DataEntity, GetDataViewByIdDto>()
                .ForMember(dest => dest.DataCategoryName, opt => opt.MapFrom(src => src.DataCategory.DataCategoryName))
                .ForMember(dest => dest.AuthorFullName, opt => opt.MapFrom(src => src.Author.FullName));

            CreateMap<DataEntity, GetDataByIdDto>();

        }
    }
}
