﻿using System;
using System.Linq;
using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntity
    {
        private readonly List<T> _items = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }

        public T? GetById(int id)
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

        public void Save()
        {
            
        }
    }
}
