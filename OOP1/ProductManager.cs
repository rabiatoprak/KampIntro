﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }

        //void = git ekle git güncelle bu işlemlerin sonucunun ne olduğğuyla ilgilenmiyorsan void kullanılır
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        

       /* public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        //topla 2 işlemnin yapar ve yazdırır. 
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }*/

    }
}
