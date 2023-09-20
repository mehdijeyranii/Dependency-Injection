namespace Dependency_Injection.Models
{
    public class ProductSum
    {
        public IRepository _repository { get; set; }
        public ProductSum(IRepository repository)
        {
            _repository = repository;
        }

        public decimal Total => _repository.Products.Sum(p => p.Price);
    }
}
