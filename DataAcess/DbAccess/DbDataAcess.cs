using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DbAccess
{
    public class DbDataAcess : IDbDataAcess
    {
        public IConfiguration _config { get; set; }
        public DbDataAcess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string StoredProcudure,
                                                         U parameters,
                                                         string connectionString = "Default")
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionString));
                return await connection.QueryAsync<T>(StoredProcudure, parameters,
                                                        commandType: CommandType.StoredProcedure);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            
        }

        public async Task SaveData<T>(string StoredProcudure,
                                      T parameters,
                                      string connectionString = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionString));
            await connection.ExecuteAsync(StoredProcudure, parameters,
                                        commandType: CommandType.StoredProcedure);
        }
    }
}
