using Application.Core.Datas.Queries.GetDataViewById;
using AutoMapper;
using Infrastructure.Persistence.SQLServer.EF.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Core.Datas.QueryServices
{
    public class GetDataViewByIdService(EFDbContext efDbContext, IMapper _mapper) : IGetDataViewByIdService
    {
        private readonly EFDbContext _efDbContext = efDbContext;
        private readonly IMapper _mapper = _mapper;

        public async Task<GetDataViewByIdDto?> Handle(Guid id, CancellationToken cancellationToken)
        {
            var dataEntity = await _efDbContext.Datas
                .Include(d => d.DataCategory)
                .Include(d => d.Author)
                .FirstOrDefaultAsync(d => d.Id == id, cancellationToken);

            if (dataEntity == null) return null;

            return _mapper.Map<GetDataViewByIdDto>(dataEntity);
        }
    }
}
