using Application.Core.Authors.Queries.Dtos;
using Application.Core.DataCategories.Queries.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.Dtos
{
    public class DataDto
    {
        public Guid Id { get; set; }
        public DataCategoryDto DataCategory { get; set; }
        public AuthorDto Author { get; set; }
        public string DataTitle { get; set; }
        public string DataSummary { get; set; }
        public string DataBody { get; set; }
        public int DataStatus { get; set; }
    }
}
