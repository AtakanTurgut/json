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
    public class StoresController : ApiController
    {
        // GET api/store
        public IEnumerable<Store> Get()
        {
            List<Store> dataItemList = new List<Store>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from sales.stores";
                dataItemList = connection.Query<Store>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/store/5
        public Store Get(int id)
        {
            Store dataItem = new Store();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from sales.stores where sales.stores.[store_id] = " + id.ToString();
                dataItem = connection.QueryFirstOrDefault<Store>(query);
            }

            return dataItem;
        }
    }
}
