using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsApp.Models
{
    public class WebSiteItem
    {
        public Guid id { get; set; }
        public string WebSiteName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ChangePasswordDate { get; set; }
    }
}
