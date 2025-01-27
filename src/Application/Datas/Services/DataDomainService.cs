using Domain.DataCategories.Repositories;
using Domain.Datas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Services
{
    public class DataDomainService : IDataDomainService
    {
        private readonly IDataCategoryRepository _dataCategoryRepository;

        public DataDomainService(IDataCategoryRepository dataCategoryRepository)
        {
            _dataCategoryRepository = dataCategoryRepository;
        }
        public async Task<bool> DataCategoryExists(Guid dataCategoryId)
        {
            return await _dataCategoryRepository.ExistsAsync(dataCategoryId);
        }
    }
}
