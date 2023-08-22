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
    public class CategoriesController : ApiController
    {
        // GET api/categories
        public IEnumerable<Category> Get()
        {
            List<Category> dataItemList = new List<Category>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from production.categories order by category_id";
                dataItemList = connection.Query<Category>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/categories/5
        public Category Get(int id)
        {
            Category dataItem = new Category();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select * from production.categories where production.categories.category_id = " + id.ToString();
                dataItem = connection.QueryFirstOrDefault<Category>(query);
            }

            return dataItem;
        }
    }
}
