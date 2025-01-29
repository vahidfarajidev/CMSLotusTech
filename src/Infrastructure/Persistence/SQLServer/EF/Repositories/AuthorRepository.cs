using AutoMapper;
using Domain.Core.Authors;
using Domain.Core.Authors.Models;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Repositories
{
    public class AuthorRepository : BaseRepository<Author, AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository(EFDbContext efDbContext, IMapper mapper) : base(efDbContext, mapper)
        {

        }
    }
}
