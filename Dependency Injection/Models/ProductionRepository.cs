namespace Dependency_Injection.Models
{
    public class ProductionRepository : IRepository
    {
        private Dictionary<string, Product> products;
        public ProductionRepository()
        {
            products = new Dictionary<string, Product>();
            new List<Product>
            {
                new Product { Name = "UI" , Price = 99M},
                new Product { Name = "PO", Price = 104M},
                new Product { Name = "AC", Price = 540M}
            }.ForEach(p => AddProduct(p));

        }
        public IEnumerable<Product> Products => products.Values;
        public Product this[string name] => products[name];


        public void AddProduct(Product product)
        {
            products[product.Name] = product;
        }

        public void DeleteProduct(Product product)
        {
            products.Remove(product.Name);
        }
    }
}
