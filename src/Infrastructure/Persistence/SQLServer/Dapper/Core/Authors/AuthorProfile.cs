using Domain.Core.Authors.Models;
using AutoMapper;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.Authors
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            // It is used for adding Data, Author
            CreateMap<Author, AuthorEntity>();
        }
    }
}
