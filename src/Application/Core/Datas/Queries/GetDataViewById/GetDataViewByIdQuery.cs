using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataViewById
{
    public record GetDataViewByIdQuery(Guid id) : IQuery<GetDataViewByIdDto>;
}
