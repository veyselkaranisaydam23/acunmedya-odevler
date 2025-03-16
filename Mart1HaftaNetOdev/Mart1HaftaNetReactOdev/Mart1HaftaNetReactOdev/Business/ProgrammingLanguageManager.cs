using System.Collections.Generic;
using DataAccess;
using Entities;

namespace Business
{
    public class ProgrammingLanguageManager : IProgrammingLanguageService
    {
        private IProgrammingLanguageRepository _repository;

        public ProgrammingLanguageManager(IProgrammingLanguageRepository repository)
        {
            _repository = repository;
        }

        public void AddLanguage(ProgrammingLanguage language) => _repository.Add(language);
        public List<ProgrammingLanguage> GetLanguages() => _repository.GetAll();
    }
}