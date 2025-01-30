using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Entities
{
    public abstract class BaseEntity
    {
        [ExplicitKey]
        public Guid Id { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public Guid? LastUpdatedBy { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
    }
}
