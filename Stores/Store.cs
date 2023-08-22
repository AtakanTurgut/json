public class Store 
{
    public int store_id { get; set; }
    public string store_name { get; set; }
    public string phone { get; set; }
    public string email { get; set; }
    public string street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string zip_code { get; set; }

    // Bir tane veri olduğu için obje olarak oluşturuldu. 
    public StoreProductDashboard store_product { get; set; }
    // Birden fazla Staff olduğu için önce modellendi sonra Array için Liste oluşturuldu.
    public List<Staff> staffs { get; set; }
}

// Obje oluşturmak için ayrı bir model olarak (class) tanımlanması gerekir.
public class StoreProductDashboard 
{
    public string brand_name { get; set; }
    public int Total { get; set; }
}

// Obje oluşturmak için ayrı bir model olarak (class) tanımlanması gerekir.
public class Staff 
{
    public int staff_id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
}