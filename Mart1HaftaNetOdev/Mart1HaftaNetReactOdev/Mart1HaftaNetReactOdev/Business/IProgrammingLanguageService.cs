using System.Collections.Generic;
using DataAccess;
using Entities;

namespace Business
{
    public interface IProgrammingLanguageService
    {
        void AddLanguage(ProgrammingLanguage language);
        List<ProgrammingLanguage> GetLanguages();
    }
}