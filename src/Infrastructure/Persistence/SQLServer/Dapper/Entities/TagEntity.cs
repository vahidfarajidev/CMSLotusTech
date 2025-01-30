using Domain.Base;
using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Entities
{
    [Table("Tags")]
    public class TagEntity : BaseEntity
    {
        public string TagName { get; private set; }
        public bool IsActive { get; private set; }
    }
}
