using BootCampProject.Core.Repositories.EntityFramework;
using BootCampProject.Entities;
using BootCampProject.Repositories.Abstracts;
using BootCampProject.Repositories.Contexts;

namespace BootCampProject.Repositories.Concretes.EntityFramework
{
    public class EfEmployeeRepository : EfRepositoryBase<Employee, BootCampProjectContext>, IEmployeeRepository
    {
        // Özel implementasyonlar burada olabilir
    }
}
