namespace ShoppingCartApp
{
    internal class Program
    {
        enum ProductCategory
        {
            Clothing,
            Electronics,
            Home,
            Beauty,
            Groceries
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Shopping Cart App");
            Console.WriteLine("Items:\n1. Laptop\n2. Chocolate\n3. Shirt\n4. Makeup\n5. Carpet");
            Console.WriteLine("How many items would you like to purchase");
            int numItems = Convert.ToInt32(Console.ReadLine());
            ShoppingCart myShoppingCart = new ShoppingCart(numItems);

            for (int i = 0; i < numItems; i++)
            {
                Console.WriteLine("Enter item " + (i + 1));
                string item = Console.ReadLine().ToLower();
                if (item == "chocolate") {
                    Product product1 = new Product("Chocolate", 20, ProductCategory.Groceries.ToString());
                } else if (item == "laptop") {
                    myShoppingCart.Products[i] = new ElectronicsProduct("Laptop", 900, ProductCategory.Electronics.ToString(), "Sonic", "Apple"); ;
                } else if (item == "shirt") {
                    myShoppingCart.Products[i] = new ClothingProduct("Shirt", 50, ProductCategory.Clothing.ToString(), "M", "Blue"); ;
                } else if (item == "makeup") {
                    myShoppingCart.Products[i] = new Product("Makeup", 190, ProductCategory.Beauty.ToString()); ;
                } else if (item == "carpet") {
                    myShoppingCart.Products[i] = new Product("Carpet", 1900, ProductCategory.Home.ToString()); ;
                }
            }

            Console.WriteLine("Would you like to view all products' information? Y or N");
            string viewInfo = Console.ReadLine();

            if (viewInfo == "Y")
            {
                for (int i = 0; i < myShoppingCart.Products.Length; i++)
                {
                    myShoppingCart.Products[i].GetInfo();
                }
            }

            Console.WriteLine("Would you like to delete a product> Y or N");
            string wantToDelete = Console.ReadLine();

            if (wantToDelete == "Y")
            {
                Console.WriteLine("Enter the category of the product you wish to delete: ");
                string toDelete = Console.ReadLine();

                myShoppingCart.RemoveProduct(toDelete);
                if (toDelete == "chocolate") {
                    
                }
            }



        }
    }
}
