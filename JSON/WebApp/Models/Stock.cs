using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Stock
    {
        public int store_id { get; set; }
        public string store_name { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int quantity { get; set; }
        public int model_year { get; set; }
        public decimal list_price { get; set; }
    }
}
