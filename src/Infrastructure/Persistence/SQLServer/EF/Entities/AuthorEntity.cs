using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Entities
{
    public class AuthorEntity : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Comment { get; set; }
    }
}
