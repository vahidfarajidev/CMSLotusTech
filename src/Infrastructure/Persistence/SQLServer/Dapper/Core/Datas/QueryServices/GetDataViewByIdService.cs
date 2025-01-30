using Application.Core.Datas.Queries.GetDataViewById;
using AutoMapper;
using Dapper;
using Infrastructure.Persistence.SQLServer.Dapper.Base;
using Microsoft.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.SQLServer.Dapper.Core.Datas.QueryServices
{
    public class GetDataViewByIdService(DapperContext dapperContext) : IGetDataViewByIdService
    {
        private readonly DapperContext _dapperContext = dapperContext;

        public async Task<GetDataViewByIdDto?> Handle(Guid id, CancellationToken cancellationToken)
        {
            using (IDbConnection dbConnection = _dapperContext.CreateConnection())
            {
                string query = $@"
                SELECT TOP 1
                    d.Id, 
                    d.DataTitle, 
                    d.DataSummary, 
                    d.DataBody, 
                    d.DataStatus, 
                    c.DataCategoryName, 
                    a.FullName AS AuthorFullName
                FROM {_dapperContext.Datas} d
                LEFT JOIN {_dapperContext.DataCategories} c ON d.DataCategoryId = c.Id
                LEFT JOIN {_dapperContext.Authors} a ON d.AuthorId = a.Id
                WHERE d.Id = @DataId";

                return await dbConnection.QueryFirstOrDefaultAsync<GetDataViewByIdDto>(query, new { DataId = id });
            }
        }
        
    }
}
