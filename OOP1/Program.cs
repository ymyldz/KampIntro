using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitInStock = 3;

//Console.WriteLine(product1.ProductName);
Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35};  


//PascalCase    //camelCase
//case sensitive küçük büyük duyarlı
 ProductManager productManager =new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);    

//int,doubleibool...değer tip
//diziler,class,abstract class,interface ... referans tip
//ref out