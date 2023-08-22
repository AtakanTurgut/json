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
    public class StoreRepository
    {
        public StoreRepository()
        {
            
        }

        public List<Store> GetDataList()
        {
            List<Store> dataList = new List<Store>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[sales].[stores]";
                dataList = connection.Query<Store>(query).ToList();
            }

            return dataList;
        }
    }
}
