using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public class GenericRepository<TItem, TKey>
    {
        public TKey? Key { get; set; }
        protected readonly List<TItem> _items = new List<TItem>();

        public void Add(TItem item)
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

    public class GenericRepositoryWithRemove<TItem, TKey> : GenericRepository<TItem, TKey>
    {
        public void Remove(TItem item)
        {
            _items.Remove(item);
        }
    }
}
