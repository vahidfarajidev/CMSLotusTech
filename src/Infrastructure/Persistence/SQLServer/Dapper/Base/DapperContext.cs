using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Persistence.SQLServer.Dapper.Entities;

namespace Infrastructure.Persistence.SQLServer.Dapper.Base
{
    public class DapperContext
    {
        private readonly string _connectionString ;

        public string? Datas { get; private set; }
        public string? DataCategories { get; private set; }
        public string? Authors { get; private set; }
        public string? Tags { get; private set; }

        public DapperContext(string connectionString)
        {
            _connectionString = connectionString;
            Datas = GetTableName<DataEntity>();
            DataCategories = GetTableName<DataCategoryEntity>();
            Authors = GetTableName<AuthorEntity>();
            Tags = GetTableName<TagEntity>();
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        public string GetTableName<T>()
        {
            var tableAttribute = typeof(T).GetCustomAttribute<TableAttribute>();
            return tableAttribute?.Name ?? typeof(T).Name;
        }
    }
}