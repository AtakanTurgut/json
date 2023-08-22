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
    public class CategoryRepository
    {
        public CategoryRepository()
        {
            
        }

        public List<Category> GetDataList()
        {
            List<Category> dataList = new List<Category>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[production].[categories]";
                dataList = connection.Query<Category>(query).ToList();
            }

            return dataList;
        }
    }
}
