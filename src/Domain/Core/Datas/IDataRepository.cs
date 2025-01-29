using Domain.Base;
using Domain.Core.Datas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Datas
{
    public interface IDataRepository : IRepository<Data>
    {
        Task<Data> GetDataByIdTestAsync(Guid id, CancellationToken cancellationToken);
    }
}
