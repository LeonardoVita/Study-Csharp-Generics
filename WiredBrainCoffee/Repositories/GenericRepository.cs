namespace WiredBrainCoffee.Repositories
{
    public class GenericRepository<TItem>
    {
        private readonly List<TItem> _items = new List<TItem>();

        public void Add(TItem item)
        {
            _items.Add(item);
        }
        public void Remove(TItem item)
        {
            _items.Remove(item);
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
