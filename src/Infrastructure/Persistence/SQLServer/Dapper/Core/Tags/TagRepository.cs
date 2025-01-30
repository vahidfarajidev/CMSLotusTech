using AutoMapper;
using Domain.Core.Tags;
using Domain.Core.Tags.Models;
using Infrastructure.Persistence.SQLServer.Dapper.Base;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.Tags
{
    public class TagRepository : BaseRepository<Tag, TagEntity>, ITagRepository
    {
        public TagRepository(DapperContext dapperContext, IMapper mapper) : base(dapperContext, mapper)
        {

        }
    }
}
