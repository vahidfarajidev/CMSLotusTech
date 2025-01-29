using Domain.Base;
using Domain.Core.Authors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Authors
{
    public interface IAuthorRepository : IRepository<Author>
    {
    }
}
