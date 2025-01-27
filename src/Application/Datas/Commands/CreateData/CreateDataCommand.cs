using Application.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Datas.Commands.CreateData
{
    public class CreateDataCommand : ICommand<Guid>
    {
        public Guid DataCategoryId { get; set; }
        public string DataTitle { get; set; }
        public string DataSummary { get; set; }
        public string DataBody { get; set; }
        public int DataStatus { get; set; }
        public Guid CreatedBy { get; set; }
    }
}
