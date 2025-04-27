using BootCampProject.Core.Repositories;
using BootCampProject.Entities;

namespace BootCampProject.Repositories.Abstracts
{
    public interface IUserRepository : IRepository<User>, IAsyncRepository<User>
    {
        // Entity'ye özel metotlar buraya eklenebilir
    }
}