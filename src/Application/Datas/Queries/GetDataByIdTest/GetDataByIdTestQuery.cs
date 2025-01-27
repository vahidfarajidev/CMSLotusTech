using Application.Base;
using Application.Datas.Dtos;
using AutoMapper;
using Domain.Datas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Queries.GetDataById
{
    public record GetDataByIdTestQuery(Guid id) : IQuery<DataDtoTest>;
}
