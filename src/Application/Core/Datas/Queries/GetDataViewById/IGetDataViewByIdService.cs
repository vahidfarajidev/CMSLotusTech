using Application.Core.Datas.Queries.GetDataById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataViewById
{
    public interface IGetDataViewByIdService
    {
        Task<GetDataViewByIdDto?> Handle(Guid id, CancellationToken cancellationToken);
    }
}
