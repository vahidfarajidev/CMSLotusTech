using Domain.Core.Authors.Models;
using Domain.Core.DataCategories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Datas.Queries.QueryModels
{
    public class DataQueryModel
    {
        public Guid Id { get; set; }
        public DataCategory DataCategory { get; set; }
        public Author Author { get; set; }
        public string DataTitle { get; set; }
        public string DataSummary { get; set; }
        public string DataBody { get; set; }
        public int DataStatus { get; set; }
    }
}
