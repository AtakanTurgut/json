public class Brand 
{
    public int brand_id { get; set; }
    public string brand_name { get; set; }
}

public class BrandManagement
{
    public List<Brand> Brands { get; set; }
}