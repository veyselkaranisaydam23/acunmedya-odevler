using Entities;

namespace DataAccess
{
    public interface ITechnologyRepository
    {
        void Add(Technology technology);
        List<Technology> GetAll();
        void Delete(int id);
        void Update(Technology technology);
        Technology GetById(int id);
    }

}
