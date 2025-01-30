using Application.Core.Datas.Queries.GetDataViewById;
using Domain.Core.Datas.Models;
using AutoMapper;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.Datas
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            // It is used for adding Data.
            CreateMap<Data, DataEntity>();
        }
    }
}
