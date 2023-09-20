namespace Dependency_Injection.Models
{
    public class Storage : IStorage
    {
        private Dictionary<string, Product> items = new Dictionary<string, Product>();
        public Product this[string key] { get => items[key]; set => items[key] = value; }

        public IEnumerable<Product> Items => items.Values;

        public bool ContainsKey(string key)
        {
            return items.ContainsKey(key);
        }

        public void RemoveItem(string key)
        {
            items.Remove(key);
        }
    }
}
