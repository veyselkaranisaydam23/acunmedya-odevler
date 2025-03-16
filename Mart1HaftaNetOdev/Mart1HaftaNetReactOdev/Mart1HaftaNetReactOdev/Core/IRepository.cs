namespace Core
{
    public interface IRepository<T>
    {
        void Add(T entity);
        List<T> GetAll();
        void Delete(int id);
        void Update(T entity);
        T GetById(int id);
    }
}