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
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            
        }

        public List<Customer> GetDataList()
        {
            List<Customer> dataList = new List<Customer>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[sales].[customers]";
                dataList = connection.Query<Customer>(query).ToList();
            }

            return dataList;
        }
    }
}
