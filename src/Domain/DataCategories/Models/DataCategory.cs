using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataCategories.Models
{
    public class DataCategory : AggregateRoot
    {
        public string DataCategoryName { get; private set; }
        public bool IsActive { get; private set; }

        public DataCategory(string dataCategoryName, bool isActive, Guid createdBy) : base(createdBy)
        {
            DataCategoryName = dataCategoryName;
            IsActive = isActive;
        }
    }
}
