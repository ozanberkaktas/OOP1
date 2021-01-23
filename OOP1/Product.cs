using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //ürün - Entity vb.
    {
        //snippet
        public int Id{ get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; } //ürünün adı
        public double UnitPrice { get; set; }  //ürün fiyatı
        public int UnitsInStock { get; set; } //stok adedi

        //CRUD 
    }
}
