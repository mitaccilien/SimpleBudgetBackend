using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using SimpleBudget.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly string _connectionString;

        public DataRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        public SelectAnIncome GetIncome(int incomeId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QueryFirstOrDefault<SelectAnIncome>(@"EXEC [dbo].[SelectAnIncome] @id = @id", new {id = incomeId });
            }
        }

        public IEnumerable<SelectAllIncome> GetIncomes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.Query<SelectAllIncome>(@"EXEC [dbo].[SelectAllIncome]");
            }
        }
    }
}
