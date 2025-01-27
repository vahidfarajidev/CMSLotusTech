using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Datas.Models
{
    public class Data : AggregateRoot
    {
        public Guid DataCategoryId { get; private set; }
        public string DataTitle { get; private set; }
        public string DataSummary { get; private set; }
        public string DataBody { get; private set; }
        public int DataStatus { get; private set; }

        private Data(string dataTitle, string dataSummary, string dataBody,
                    int dataStatus, Guid dataCategoryId, Guid createdBy) : base(createdBy)
        {
            Guard(createdBy);
            DataTitle = dataTitle;
            DataSummary = dataSummary;
            DataBody = dataBody;
            DataStatus = dataStatus;
            DataCategoryId = dataCategoryId;
        }

        public static Data Create(string dataTitle, string dataSummary, string dataBody,
                    int dataStatus, Guid dataCategoryId, Guid createdBy)
        {
            var data = new Data(dataTitle, dataSummary, dataBody, dataStatus, dataCategoryId, createdBy);
            return data;
        }

        void Guard(Guid createdBy)
        {
            if (createdBy == Guid.Empty)
                throw new Exception("CreatedBy is required!");
        }

    }
}

