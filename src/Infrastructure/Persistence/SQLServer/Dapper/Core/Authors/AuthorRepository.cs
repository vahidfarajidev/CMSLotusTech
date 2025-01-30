using AutoMapper;
using Domain.Core.Authors;
using Domain.Core.Authors.Models;
using Infrastructure.Persistence.SQLServer.Dapper.Base;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.Authors
{
    public class AuthorRepository : BaseRepository<Author, AuthorEntity>, IAuthorRepository
    {
        public AuthorRepository(DapperContext dapperContext, IMapper mapper) : base(dapperContext, mapper)
        {

        }
    }
}
