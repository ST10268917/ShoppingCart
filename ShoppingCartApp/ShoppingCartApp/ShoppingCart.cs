using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ShoppingCart
    {
        enum ProductCategory
        {
            Clothing,
            Electronics,
            Home,
            Beauty,
            Groceries
        }

        public Product[] Products { get; }
        public int ItemCount { get; }

        public ShoppingCart(int capacity)
        {
            Products = new Product[capacity];

        }

        public void AddProduct(Product product)
        {
            Product[] updatedArray = new Product[Products.Length + 1];

            Products.CopyTo(updatedArray, 0);
            updatedArray[^1] = product;

            Console.WriteLine("The element has been added.");
        }

        public void RemoveProduct(Product product)
        {
            int? RemoveAt = null;
            for (int k = 0; k < Products.Length; k++)
            {
                if (product == Products[k])
                {
                    RemoveAt = k;
                }
            }
            Product[] updatedArray = new Product[Products.Length - 1];

            int i = 0;
            int j = 0;
            while (i < Products.Length)
            {
                if (i != RemoveAt)
                {
                    updatedArray[j] = Products[i];
                    j++;
                }

                i++;
            }

            Console.WriteLine("The element has been removed.");

        }
    }
}
