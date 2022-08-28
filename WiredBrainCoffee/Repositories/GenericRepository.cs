using System;
using System.Linq;
using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public class GenericRepository<T> where T : class, IEntity
    {
        private readonly List<T> _items = new List<T>();

        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void Remove(T item)
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
