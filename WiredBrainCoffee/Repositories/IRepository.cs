using WiredBrainCoffee.Entities;

namespace WiredBrainCoffee.Repositories
{
    public interface IWriteRepository<in T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
    }
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
    }
    public interface IRepository<T> : IWriteRepository<T>, IReadRepository<T> where T : IEntity
    {        
        
    }
}