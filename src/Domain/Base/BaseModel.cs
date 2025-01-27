using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base
{
    public abstract class BaseModel
    {
        public Guid Id { get; private set; }
        public Guid CreatedBy { get; private set; }
        public DateTime CreatedDateTime { get; private set; }
        public Guid? LastUpdatedBy { get; private set; }
        public DateTime? LastUpdateDateTime { get; private set; }

        protected BaseModel(Guid createdBy)
        {
            Id = Guid.NewGuid();
            CreatedDateTime = DateTime.UtcNow;
            CreatedBy = createdBy;
        }
    }
}
