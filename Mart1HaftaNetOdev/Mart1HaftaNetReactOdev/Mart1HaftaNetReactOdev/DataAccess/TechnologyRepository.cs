using Entities;

namespace DataAccess
{

    public class TechnologyRepository : ITechnologyRepository
    {
        private List<Technology> technologies = new List<Technology>();

        public void Add(Technology technology) => technologies.Add(technology);
        public List<Technology> GetAll() => technologies;
        public void Delete(int id) => technologies.RemoveAll(t => t.Id == id);
        public void Update(Technology technology)
        {
            var tech = technologies.Find(t => t.Id == technology.Id);
            if (tech != null) tech.Name = technology.Name;
        }
        public Technology GetById(int id) => technologies.Find(t => t.Id == id);
    }
}
