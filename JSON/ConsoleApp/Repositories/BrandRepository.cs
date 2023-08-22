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
    public class BrandRepository
    {
        public BrandRepository()
        {
            
        }

        public List<Brand> GetDataList()
        {
            List<Brand> dataList = new List<Brand>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[production].[brands]";
                dataList = connection.Query<Brand>(query).ToList();
            }

            return dataList;
        }
    }
}
