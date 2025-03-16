using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        private List<ProgrammingLanguage> languages = new List<ProgrammingLanguage>();

        public void Add(ProgrammingLanguage language) => languages.Add(language);
        public List<ProgrammingLanguage> GetAll() => languages;
        public void Delete(int id) => languages.RemoveAll(l => l.Id == id);
        public void Update(ProgrammingLanguage language)
        {
            var lang = languages.Find(l => l.Id == language.Id);
            if (lang != null) lang.Name = language.Name;
        }
        public ProgrammingLanguage GetById(int id) => languages.Find(l => l.Id == id);
    }

}