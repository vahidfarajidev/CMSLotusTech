using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.EF.Entities
{
    public class TagEntity : BaseEntity
    {
        public string TagName { get; private set; }
        public bool IsActive { get; private set; }
    }
}
