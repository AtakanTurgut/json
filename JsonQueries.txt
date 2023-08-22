/* Categories */
select * from production.categories

/* Customers */
select * from sales.customers

/* Brands */
select * from production.brands

/* Stores */
select * from sales.stores
select * from [sales].[staffs] where store_id = 1

select top 1 brand_name, COUNT(1) as Total from [sales].[stores] Store 
inner join [production].[stocks] Stocks on Store.[store_id] = Stocks.[store_id]
inner join [production].[products] Product on Stocks.[product_id] = Product.[product_id]
inner join [production].[brands] Brands on Product.[brand_id] = Brands.[brand_id]
group by brand_name order by COUNT(1) desc

/* --- Console App --- */
/* Brand Repository */
select * from [DapperDB].[production].[brands]

/* Category Repository */
select * from [DapperDB].[production].[categories]

/* Customer Repository */
select * from [DapperDB].[sales].[customers]

/* Product Repository */
select * from [DapperDB].[production].[products]

/* Staff Repository */
select * from [DapperDB].[sales].[staffs]

/* Stock Repository */
select * from [DapperDB].[production].[stocks]

/* Store Repository */
select * from [DapperDB].[sales].[stores]

/* --- Forms App --- 

    DirectoryAddress = "C:\\Users\\Excalibur\\Desktop\\json";
    JsonDatabase = DirectoryAddress + "\\MyAccounts.json";
*/

/* --- Web App --- */
/* Brands Controller */
select brand_id, brand_name from production.brands order by brand_id
select brand_id, brand_name from production.brands where production.brands.brand_id = 1

/* Categories Controller */
select * from production.categories order by category_id
select * from production.categories where production.categories.category_id =  1

/* Customers Controller */
select * from sales.customers order by customer_id
select * from sales.customers where sales.customers.customer_id = 1

/* Products Controller */
select product_id, product_name, brand_name, category_name, model_year, list_price from production.products
inner join production.brands on production.products.brand_id = production.brands.brand_id 
inner join production.categories on production.products.category_id = production.categories.category_id 
order by category_name, brand_name

select product_id, product_name, brand_name, category_name, model_year, list_price from production.products 
inner join production.brands on production.products.brand_id = production.brands.brand_id 
inner join production.categories on production.products.category_id = production.categories.category_id 
where production.products.product_id = 1

/* Staffs Controller */
select * from sales.staffs order by staff_id
select * from sales.staffs where sales.staffs.staff_id = 1

/* Stocks Controller */
select production.stocks.[store_id], store_name, production.products.[product_id], product_name, quantity, category_name, model_year, list_price 
from production.stocks
inner join sales.stores on sales.stores.store_id = production.stocks.store_id 
inner join production.products on production.products.product_id = production.stocks.product_id  
inner join production.categories on production.categories.category_id = production.products.category_id

select production.stocks.[store_id], store_name, production.products.[product_id], product_name, quantity, category_name, model_year, list_price 
from production.stocks 
inner join sales.stores on sales.stores.store_id = production.stocks.store_id 
inner join production.products on production.products.product_id = production.stocks.product_id 
inner join production.categories on production.categories.category_id = production.products.category_id 
where production.stocks.[store_id] = 1

/* Stores */
select * from sales.stores
select * from sales.stores where sales.stores.[store_id] = 1
