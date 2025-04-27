using BootCampProject.Core.Repositories;
using BootCampProject.Entities;

namespace BootCampProject.Repositories.Abstracts
{
    public interface IEmployeeRepository : IRepository<Employee>, IAsyncRepository<Employee>
    {
        // Entity'ye özel metotlar buraya eklenebilir
    }
}
