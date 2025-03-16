using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public interface IProgrammingLanguageRepository
    {
        void Add(ProgrammingLanguage language);
        List<ProgrammingLanguage> GetAll();
        void Delete(int id);
        void Update(ProgrammingLanguage language);
        ProgrammingLanguage GetById(int id);
    }

}