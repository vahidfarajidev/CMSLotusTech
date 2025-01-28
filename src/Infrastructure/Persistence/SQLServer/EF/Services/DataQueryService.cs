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
    public class DataQueryService(AppDbContext dbContext, IMapper _mapper) : IDataQueryService
    {
        private readonly AppDbContext _dbContext = dbContext;
        private readonly IMapper _mapper = _mapper;

        public async Task<DataQueryModel> GetDataById(Guid id)
        {
            var dataEntity = await _dbContext.Datas
                .Include(d => d.DataCategory)
                .Include(d=> d.Author)
                .FirstOrDefaultAsync(d => d.Id == id);
            
            return _mapper.Map<DataQueryModel>(dataEntity);
        }
    }
}
