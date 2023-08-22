using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class StaffsController : ApiController
    {
        // GET api/staffs
        public IEnumerable<Staff> Get()
        {
            List<Staff> dataItemList = new List<Staff>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from sales.staffs order by staff_id";
                dataItemList = connection.Query<Staff>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/staffs/5
        public Staff Get(int id)
        {
            Staff dataItem = new Staff();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from sales.staffs where sales.staffs.staff_id = " + id.ToString();
                dataItem = connection.QueryFirstOrDefault<Staff>(query);
            }

            return dataItem;
        }
    }
}
