﻿using AutoMapper;
using Domain.Authors.Models;
using Domain.Authors.Repositories;
using Domain.DataCategories.Models;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Repositories
{
    internal class AuthorRepository : IAuthorRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public AuthorRepository(AppDbContext DbContext, IMapper mapper)
        {
            _dbContext = DbContext;
            _mapper = mapper;
        }
        public Task AddAsync(Author model, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return (await _dbContext.Authors.FirstOrDefaultAsync(a => a.Id == id)) != null;
        }

        public Task<IEnumerable<Author>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Author?> GetByIdAsync(Guid id)
        {
            var authorEntity = await _dbContext.Set<AuthorEntity>().FirstOrDefaultAsync(a => a.Id.Equals(id));
            return _mapper.Map<Author>(authorEntity);
        }

        public Task UpdateAsync(Author model)
        {
            throw new NotImplementedException();
        }
    }
}
