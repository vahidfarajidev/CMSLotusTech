using Application.Datas.Dtos;
using Application.Datas.QueryModels;
using AutoMapper;
using Domain.DataCategories.Models;
using Domain.Datas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Mappings
{
    public class DataProfile:Profile
    {
        public DataProfile()
        {
            CreateMap<Data, DataDtoTest>();
            CreateMap<DataQueryModel, DataDto>();
        }
    }
}
