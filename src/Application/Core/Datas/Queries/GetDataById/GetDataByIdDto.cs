using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataById
{
    public class GetDataByIdDto : BaseDto
    {
        public Guid DataCategoryId { get; private set; }
        public Guid AuthorId { get; private set; }
        public string DataTitle { get; private set; }
        public string DataSummary { get; private set; }
        public string DataBody { get; private set; }
        public int DataStatus { get; private set; }
    }
}
