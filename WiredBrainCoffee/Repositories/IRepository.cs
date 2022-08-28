using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Add(T item);
        void Remove(T item);
        void save();
    }
}