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
    public class BrandsController : ApiController
    {
        // GET api/brands
        public IEnumerable<Brand> Get()
        {
            List<Brand> dataItemList = new List<Brand>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select brand_id, brand_name from production.brands order by brand_id";
                dataItemList = connection.Query<Brand>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/brands/5
        public Brand Get(int id)
        {
            Brand dataItem = new Brand();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select brand_id, brand_name from production.brands where production.brands.brand_id = " + id.ToString();
                dataItem = connection.QueryFirstOrDefault<Brand>(query);
            }

            return dataItem;
        }
    }
}
