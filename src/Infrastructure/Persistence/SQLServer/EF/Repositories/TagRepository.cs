﻿using AutoMapper;
using Domain.Tags.Repositories;
using Domain.Tags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly EFDbContext _efDbContext;
        private readonly IMapper _mapper;

        public TagRepository(EFDbContext efDbContext, IMapper mapper)
        {
            _efDbContext = efDbContext;
            _mapper = mapper;
        }

        public Task AddAsync(Tag entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tag>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tag?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Tag entity)
        {
            throw new NotImplementedException();
        }
    }
}
