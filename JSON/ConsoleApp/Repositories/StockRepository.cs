using ConsoleApp.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Repositories
{
    public class StockRepository
    {
        public StockRepository()
        {
            
        }

        public List<Stock> GetDataList()
        {
            List<Stock> dataList = new List<Stock>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[production].[stocks]";
                dataList = connection.Query<Stock>(query).ToList();
            }

            return dataList;
        }
    }
}
