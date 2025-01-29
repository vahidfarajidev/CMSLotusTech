using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataById
{
    public interface IGetDataByIdService
    {
        Task<GetDataByIdDto?> Handle(Guid id, CancellationToken cancellationToken);
    }
}
