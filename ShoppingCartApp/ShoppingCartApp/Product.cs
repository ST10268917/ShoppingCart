using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoppingCartApp
{

    internal class Product
    {

        public string Name {  get; set; }
        public double Price { get; set; }   
        public string ProductCategory { get; set; }


        public Product(string name, double price, string productCategory)
        {
            this.Name = name;
            this.Price = price;
            this.ProductCategory = productCategory;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Product Category: " + this.ProductCategory);
        }
    }
}
