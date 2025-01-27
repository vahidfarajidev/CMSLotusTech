using Domain.Base;
using Domain.Datas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Datas.Repositories
{
    public interface IDataRepository : IRepository<Data>
    {
        Task<Data> GetDataByIdTestAsync(Guid id);
    }
}
