using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Entities
{
    [Table("DataCategories")]
    public class DataCategoryEntity : BaseEntity
    {
        public string DataCategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}
