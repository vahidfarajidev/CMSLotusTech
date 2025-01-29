using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Datas.Services
{
    public interface IDataDomainService
    {
        public Task<bool> DataCategoryExists(Guid dataCategoryId, CancellationToken cancellationToken);
        public Task<bool> AuthorExists(Guid authorId, CancellationToken cancellationToken);
    }
}
