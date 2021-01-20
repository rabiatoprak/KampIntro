using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5,
                UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase   //camelCase
            //case sensitive = küçük büyük harf duyarlı
            //steak=soltaraf                heap=sağ
            ProductManager productManager = new ProductManager();
            //parametre
            productManager.Add(product1);

            //productManager.Topla2(3, 6);

            //reurn alınan reğerin üzerinde işlem yapabilmeyi sağlar. void ise git yap der ekranda gösterir ve o işlemin sonucu üzerinde başka bir işlem yapılmaz
            ///int toplamasonucu = productManager.Topla(3, 6);
            
        }
    }
}
