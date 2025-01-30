using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Entities
{
    [Table("Authors")]
    public class AuthorEntity : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
    }
}
