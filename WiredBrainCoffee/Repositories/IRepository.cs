using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T item);
        T GetById(int id);
        void Remove(T item);
        void save();
    }
}