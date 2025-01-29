using Application.Core.Datas.Queries.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries
{
    public interface IDataQueryService
    {
        Task<DataQueryModel> GetDataById(Guid id);
    }
}
