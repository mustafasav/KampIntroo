﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoriId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoriId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 10 };
            
            //PascalCase    //camelCase
            //case sensitive >>> Büyük küçük harf duyarlı. B b eşit değildir.
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int,double,bool.. değer tip
            // diziler, class, abstract class, interface... referans tip
            

        }
    }
}
