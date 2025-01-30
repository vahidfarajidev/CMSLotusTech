using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.GetDataViewById
{
    public class GetDataViewByIdDto : BaseDataDto
    {
        public string DataCategoryName { get; set; }
        public string AuthorFullName { get; set; }
    }
}
