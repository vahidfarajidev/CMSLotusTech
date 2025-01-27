using Domain.DataCategories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.QueryModels
{
    public class DataQueryModel
    {        
        public Guid Id { get; set; }
        public DataCategory DataCategory { get; set; }
        public string DataTitle { get; set; }
        public string DataSummary { get; set; }
        public string DataBody { get; set; }
        public int DataStatus { get; set; }
    }
}
