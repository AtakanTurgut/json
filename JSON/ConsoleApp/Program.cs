// Model , Repository, Dapper, Newtonsoft
using ConsoleApp.Models;
using ConsoleApp.Repositories;
using Newtonsoft.Json;

/* Brand */
BrandRepository brandRepository = new BrandRepository();
List<Brand> dataListBrand = brandRepository.GetDataList();

string jsonDataListBrand = Newtonsoft.Json.JsonConvert.SerializeObject(dataListBrand);

List<Brand> jsonDataReadBrand = JsonConvert.DeserializeObject<List<Brand>>(jsonDataListBrand);

/* Category */
CategoryRepository categoryRepository = new CategoryRepository();
List<Category> dataListCategory = categoryRepository.GetDataList();

string jsonDataListCategory = Newtonsoft.Json.JsonConvert.SerializeObject(dataListCategory);
string jsonDataCategory = Newtonsoft.Json.JsonConvert.SerializeObject(dataListCategory[0]);

List<Category> jsonDataReadCategory = JsonConvert.DeserializeObject<List<Category>>(jsonDataListCategory);

/* Customer */
CustomerRepository customerRepository = new CustomerRepository();
List<Customer> dataListCustomer = customerRepository.GetDataList();

string jsonDataListCustomer = Newtonsoft.Json.JsonConvert.SerializeObject(dataListCustomer);
string jsonDataCustomer = Newtonsoft.Json.JsonConvert.SerializeObject(dataListCustomer[0]);

List<Customer> jsonDataReadCustomer = JsonConvert.DeserializeObject<List<Customer>>(jsonDataListCustomer);

/* Product */
ProductRepository productRepository = new ProductRepository();
List<Product> dataListProduct = productRepository.GetDataList();

string jsonDataListProduct = Newtonsoft.Json.JsonConvert.SerializeObject(dataListProduct);
string jsonDataProduct = Newtonsoft.Json.JsonConvert.SerializeObject(dataListProduct[0]);

List<Product> jsonDataReadProduct = JsonConvert.DeserializeObject<List<Product>>(jsonDataListProduct);

/* Staff */
StaffRepository staffRepository = new StaffRepository();
List<Staff> dataListStaff = staffRepository.GetDataList();

string jsonDataListStaff = Newtonsoft.Json.JsonConvert.SerializeObject(dataListStaff);
string jsonDataStaff = Newtonsoft.Json.JsonConvert.SerializeObject(dataListStaff[0]);

List<Staff> jsonDataReadStaff = JsonConvert.DeserializeObject<List<Staff>>(jsonDataListStaff);

/* Stock */
StockRepository stockRepository = new StockRepository();
List<Stock> dataListStock = stockRepository.GetDataList();

string jsonDataListStock = Newtonsoft.Json.JsonConvert.SerializeObject(dataListStock);
string jsonDataStock = Newtonsoft.Json.JsonConvert.SerializeObject(dataListStock[0]);

List<Stock> jsonDataReadStock = JsonConvert.DeserializeObject<List<Stock>>(jsonDataListStock);

/* Store */
StoreRepository storeRepository = new StoreRepository();
List<Store> dataListStore = storeRepository.GetDataList();

string jsonDataListStore = Newtonsoft.Json.JsonConvert.SerializeObject(dataListStore);
string jsonDataStore = Newtonsoft.Json.JsonConvert.SerializeObject(dataListStore[0]);

List<Store> jsonDataReadStore = JsonConvert.DeserializeObject<List<Store>>(jsonDataListStore);

Console.WriteLine();
Console.ReadLine();