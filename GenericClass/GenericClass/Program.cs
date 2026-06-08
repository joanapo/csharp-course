namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class ProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {

        }

        public void Remove(Product entity)
        {

        }
    }
}
