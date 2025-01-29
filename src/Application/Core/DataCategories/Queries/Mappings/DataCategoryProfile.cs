using Application.Core.DataCategories.Queries.Dtos;
using AutoMapper;
using Domain.Core.DataCategories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.DataCategories.Queries.Mappings
{
    public class DataCategoryProfile : Profile
    {
        public DataCategoryProfile()
        {
            CreateMap<DataCategory, DataCategoryDto>();
        }
    }
}
