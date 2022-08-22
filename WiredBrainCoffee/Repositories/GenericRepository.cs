using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public class GenericRepository<T>
    {
        protected readonly List<T> _items = new List<T>();

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

    public class GenericRepositoryWithRemove<T> : GenericRepository<T>
    {
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
