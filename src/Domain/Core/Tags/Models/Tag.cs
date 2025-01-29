using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Tags.Models
{
    public class Tag : AggregateRoot
    {
        public string TagName { get; private set; }
        public bool IsActive { get; private set; }

        public Tag(string tagName, bool isActive, Guid createdBy) : base(createdBy)
        {
            TagName = tagName;
            IsActive = isActive;
        }
    }
}
