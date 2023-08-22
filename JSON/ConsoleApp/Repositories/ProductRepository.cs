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
    public class ProductRepository
    {
        public ProductRepository()
        {
            
        }

        public List<Product> GetDataList()
        {
            List<Product> dataList = new List<Product>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[production].[products]";
                dataList = connection.Query<Product>(query).ToList();
            }

            return dataList;
        }
    }
}
