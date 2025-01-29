using AutoMapper;
using Infrastructure.Persistence.SQLServer.EF.Entities;
using Domain.Core.Tags;
using Domain.Core.Tags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Repositories
{
    public class TagRepository : BaseRepository<Tag, TagEntity>, ITagRepository
    {
        public TagRepository(EFDbContext efDbContext, IMapper mapper) : base(efDbContext, mapper)
        {

        }
    }
}
