using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Entities
{
    [Table("Datas")]
    public class DataEntity : BaseEntity
    {
        public Guid DataCategoryId { get; set; }
         public Guid AuthorId { get; set; }
        public string DataTitle { get; set; }
        public string DataSummary { get; set; }
        public string DataBody { get; set; }
        public int DataStatus { get; set; }
    }
}
