using Microsoft.Extensions.Configuration;

namespace DataAcess.DbAccess
{
    public interface IDbDataAcess
    {
        IConfiguration _config { get; set; }

        Task<IEnumerable<T>> LoadData<T, U>(string StoredProcudure, U parameters, string connectionString = "Default");
        Task SaveData<T>(string StoredProcudure, T parameters, string connectionString = "Default");
    }
}