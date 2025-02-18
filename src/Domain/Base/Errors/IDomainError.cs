﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Base.Errors
{
    public interface IDomainError
    {
        string? ErrorMessage { get; init; }
        ErrorType ErrorType { get; init; }
        public List<string>? Errors { get; init; }
    }
}
