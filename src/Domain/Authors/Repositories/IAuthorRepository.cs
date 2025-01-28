﻿using Domain.Authors.Models;
using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authors.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
    }
}
