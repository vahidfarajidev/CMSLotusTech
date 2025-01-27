using Application.DataCategories.Dtos;
using AutoMapper;
using Domain.DataCategories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataCategories.Mappings
{
    public class DataCategoryProfile : Profile
    {
        public DataCategoryProfile()
        {
            CreateMap<DataCategory, DataCategoryDto>();
        }
    }
}
