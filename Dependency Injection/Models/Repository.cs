namespace Dependency_Injection.Models
{
    public class Repository : IRepository
    {
        private Dictionary<string, Product> products;
        private readonly IStorage _storage;
        public Repository(IStorage storage)
        {
            _storage = storage;

            products = new Dictionary<string, Product>();
            new List<Product>
            {
                new Product { Name = "NF", Price = 23M},
                new Product { Name = "LA", Price = 87M},
                new Product { Name = "HR", Price = 91M}
            }.ForEach(p => AddProduct(p));
        }
        public IEnumerable<Product> Products => _storage.Items;
        public Product this[string name] => _storage[name];

        public void AddProduct(Product product)
        {
            _storage[product.Name] = product;
        }

        public void DeleteProduct(Product product)
        {
            _storage.RemoveItem(product.Name);
        }

        private string guid = System.Guid.NewGuid().ToString();

        public override string ToString()
        {
            return guid;
        }
    }
}
