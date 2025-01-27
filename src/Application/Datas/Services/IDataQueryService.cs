using Application.Datas.QueryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Services
{
    public interface IDataQueryService
    {
        Task<DataQueryModel> GetDataById(Guid id);
    }
}
