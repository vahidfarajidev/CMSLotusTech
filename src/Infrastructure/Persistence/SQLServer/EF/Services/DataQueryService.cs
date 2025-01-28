using Application.Datas.QueryModels;
using Application.Datas.Services;
using AutoMapper;
using Domain.Datas.Models;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Services
{
    public class DataQueryService(EFDbContext efDbContext, IMapper _mapper) : IDataQueryService
    {
        private readonly EFDbContext _efDbContext = efDbContext;
        private readonly IMapper _mapper = _mapper;

        public async Task<DataQueryModel> GetDataById(Guid id)
        {
            var dataEntity = await _efDbContext.Datas
                .Include(d => d.DataCategory)
                .Include(d=> d.Author)
                .FirstOrDefaultAsync(d => d.Id == id);
            
            return _mapper.Map<DataQueryModel>(dataEntity);
        }
    }
}
