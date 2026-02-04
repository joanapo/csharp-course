namespace ListsApp
{
    internal class Program
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product {Name = "Apple", Price = 0.80},
                new Product {Name = "Banana", Price = 0.30},
                new Product {Name = "Cherry", Price = 3.80},
            };

            products.Add(new Product { Name = "Berries", Price = 2.99 });

            List<Product> cheapProducts = products.Where(p => p.Price < 1.0).ToList();

            Console.WriteLine("Available Products for less than $1");

            foreach (Product product in cheapProducts)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}.");
            }

            Console.WriteLine("Available Products");

            foreach (Product product in products)
            {
                Console.WriteLine($"Product name: {product.Name} for {product.Price}.");
            }

            Console.ReadLine();
        }
    }
}
