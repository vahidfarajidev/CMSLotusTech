using Application.Core.Datas.Queries.GetDataById;
using AutoMapper;
using Infrastructure.Persistence.SQLServer.EF.Base;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Core.Datas.QueryServices
{
    public class GetDataByIdService(EFDbContext eFDbContext, IMapper mapper) : IGetDataByIdService
    {
        private readonly EFDbContext _eFDbContext = eFDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<GetDataByIdDto?> Handle(Guid id, CancellationToken cancellationToken)
        {
            var dataEntity = await _eFDbContext.Set<DataEntity>().FirstOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);

            if (dataEntity == null) return null;

            return _mapper.Map<GetDataByIdDto>(dataEntity);
        }
    }
}
