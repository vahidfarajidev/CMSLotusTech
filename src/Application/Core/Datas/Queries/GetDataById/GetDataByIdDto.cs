using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataById
{
    public class GetDataByIdDto : BaseDataDto
    {
        public Guid DataCategoryId { get; set; }
        public Guid AuthorId { get; set; }
    }
}
