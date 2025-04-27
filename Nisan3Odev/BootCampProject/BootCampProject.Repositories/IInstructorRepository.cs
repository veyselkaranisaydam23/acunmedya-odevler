using BootCampProject.Core.Repositories;
using BootCampProject.Entities;

namespace BootCampProject.Repositories.Abstracts
{
    public interface IInstructorRepository : IRepository<Instructor>, IAsyncRepository<Instructor>
    {
        // Entity'ye özel metotlar buraya eklenebilir
    }
}
