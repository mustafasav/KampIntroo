using System;
using System.Collections.Generic;
using System.Text;

//Ürün classında sadece ürüne ait özellikler tutulur. 
//işlem kodları burada olmaz. (ekle,sil,güncelleme gibi)
namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoriId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
