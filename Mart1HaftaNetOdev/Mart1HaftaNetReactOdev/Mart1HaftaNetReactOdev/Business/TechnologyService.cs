using DataAccess;
using Entities;

namespace Business
{
    public class TechnologyManager : ITechnologyService
    {
        private ITechnologyRepository _repository;

        public TechnologyManager(ITechnologyRepository repository)
        {
            _repository = repository;
        }

        public void AddTechnology(Technology technology) => _repository.Add(technology);
        public List<Technology> GetTechnologies() => _repository.GetAll();
    }
}
