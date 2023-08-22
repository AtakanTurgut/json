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
    public class ProductsController : ApiController
    {
        // GET api/values
        public IEnumerable<Product> Get()
        {
            List<Product> dataItemList = new List<Product>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select product_id, product_name, brand_name, category_name, model_year, list_price from production.products\r\ninner join production.brands on production.products.brand_id = production.brands.brand_id\r\ninner join production.categories on production.products.category_id = production.categories.category_id\r\norder by category_name, brand_name";
                dataItemList = connection.Query<Product>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/values/5
        public Product Get(int id)
        {
            Product dataItem = new Product();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select product_id, product_name, brand_name, category_name, model_year, list_price from production.products\r\ninner join production.brands on production.products.brand_id = production.brands.brand_id\r\ninner join production.categories on production.products.category_id = production.categories.category_id\r\nwhere production.products.product_id = " + id.ToString();
                dataItem = connection.QueryFirstOrDefault<Product>(query);
            }

            return dataItem;
        }
    }
}
