using Domain.Authors.Repositories;
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
        private readonly IAuthorRepository _authorRepository;

        public DataDomainService(IDataCategoryRepository dataCategoryRepository,
            IAuthorRepository authorRepository)
        {
            _dataCategoryRepository = dataCategoryRepository;
            _authorRepository = authorRepository;
        }

        public async Task<bool> DataCategoryExists(Guid dataCategoryId, CancellationToken cancellationToken)
        {
            return await _dataCategoryRepository.ExistsAsync(dataCategoryId, cancellationToken);
        }

        public async Task<bool> AuthorExists(Guid authorId, CancellationToken cancellationToken)
        {
            return await _authorRepository.ExistsAsync(authorId, cancellationToken);
        }
    }
}
