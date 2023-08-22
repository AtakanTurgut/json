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
    public class StaffRepository
    {
        public StaffRepository()
        {
            
        }

        public List<Staff> GetDataList()
        {
            List<Staff> dataList = new List<Staff>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                string query = "select * from [DapperDB].[sales].[staffs]";
                dataList = connection.Query<Staff>(query).ToList();
            }

            return dataList;
        }
    }
}
