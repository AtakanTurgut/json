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
    public class CustomersController : ApiController
    {
        // GET api/customers
        public IEnumerable<Customer> Get()
        {
            List<Customer> dataItemList = new List<Customer>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from sales.customers order by customer_id";
                dataItemList = connection.Query<Customer>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/customers/5
        public Customer Get(int id)
        {
            Customer dataItem = new Customer();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from sales.customers where sales.customers.customer_id = " + id.ToString();
                dataItem = connection.QueryFirstOrDefault<Customer>(query);
            }

            return dataItem;
        }
    }
}
