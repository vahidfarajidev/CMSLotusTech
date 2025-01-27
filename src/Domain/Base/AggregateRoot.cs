﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base
{
    public abstract class AggregateRoot : BaseModel
    {
        protected AggregateRoot(Guid createdBy) : base(createdBy)
        {
        }
    }
}

