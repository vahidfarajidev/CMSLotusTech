using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Entities
{
    public class DataCategoryEntity : BaseEntity
    {
        public string DataCategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}
