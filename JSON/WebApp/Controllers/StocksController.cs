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
    public class StocksController : ApiController
    {
        // GET api/stocks
        public IEnumerable<Stock> Get()
        {
            List<Stock> dataItemList = new List<Stock>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select production.stocks.[store_id], store_name, production.products.[product_id], product_name, quantity, category_name, model_year, list_price from production.stocks\r\ninner join sales.stores on sales.stores.store_id = production.stocks.store_id\r\ninner join production.products on production.products.product_id = production.stocks.product_id \r\ninner join production.categories on production.categories.category_id = production.products.category_id";
                dataItemList = connection.Query<Stock>(query).ToList();
            }

            return dataItemList;
        }

        // GET api/stocks/5
        public List<Stock> Get(int id)
        {
            List<Stock> dataItem = new List<Stock>();

            using (var connection = new SqlConnection("data source = DESKTOP-R6K64T9\\SQLEXPRESS; initial catalog = DapperDB; integrated security = true"))
            {
                var query = "select production.stocks.[store_id], store_name, production.products.[product_id], product_name, quantity, category_name, model_year, list_price from production.stocks inner join sales.stores on sales.stores.store_id = production.stocks.store_id inner join production.products on production.products.product_id = production.stocks.product_id inner join production.categories on production.categories.category_id = production.products.category_id where production.stocks.[store_id] = " + id.ToString();
                dataItem = connection.Query<Stock>(query).ToList();
            }

            return dataItem;
        }
    }
}
