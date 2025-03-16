using DataAccess;
using Entities;
using System;
namespace Business
{
    public interface ITechnologyService
    {
        void AddTechnology(Technology technology);
        List<Technology> GetTechnologies();
    }

}
