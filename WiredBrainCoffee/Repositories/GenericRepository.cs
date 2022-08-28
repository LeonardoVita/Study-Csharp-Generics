using System;
using System.Linq;
using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public class GenericRepository<TItem,TKey> 
        where TItem : class, IEntity
        //where TKey : struct
        where TKey : TItem
    {
        private readonly List<TItem> _items = new List<TItem>();        

        public TItem GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Add(TItem item)
        {
            item.Id = _items.Count + 1;
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
