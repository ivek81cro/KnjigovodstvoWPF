using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace KnjigeDataManager.Library.Internal.DataAccess
{
    internal class SqlDataAccess
    {
        private IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public string GetConnectionString(string name)
        {
            return _config.GetConnectionString(name);
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection
                    .Query<T>(
                        storedProcedure,
                        parameters,
                        commandType: CommandType.StoredProcedure
                        )
                    .ToList();

                return rows;
            }
        }

        public void SaveData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure,
                                   parameters,
                                   commandType: CommandType.StoredProcedure);
            }
        }
    }
}
