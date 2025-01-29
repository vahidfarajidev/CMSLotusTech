using AutoMapper;
using Domain.Core.Datas;
using Domain.Core.Datas.Models;
using Infrastructure.Persistence.SQLServer.EF.Base;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Core.Datas
{
    public class DataRepository : BaseRepository<Data, DataEntity>, IDataRepository
    {

        public DataRepository(EFDbContext efDbContext, IMapper mapper) : base(efDbContext, mapper)
        {

        }
    }
}
