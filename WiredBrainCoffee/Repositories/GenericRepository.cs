using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public class GenericRepository<T>
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void save()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
