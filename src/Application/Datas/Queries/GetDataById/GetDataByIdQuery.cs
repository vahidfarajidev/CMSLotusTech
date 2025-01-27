using Application.Base;
using Application.Datas.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Queries.GetDataByIdWithInfo
{
    public record GetDataByIdQuery(Guid id) : IQuery<DataDto>;
}
