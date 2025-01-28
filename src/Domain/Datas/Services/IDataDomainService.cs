using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Datas.Services
{
    public interface IDataDomainService
    {
        public Task<bool> DataCategoryExists(Guid dataCategoryId);
        public Task<bool> AuthorExists(Guid authorId);
    }
}
