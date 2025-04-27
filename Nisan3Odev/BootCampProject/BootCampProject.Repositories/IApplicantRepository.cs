using BootCampProject.Core.Repositories;
using BootCampProject.Entities;

namespace BootCampProject.Repositories.Abstracts
{
    public interface IApplicantRepository : IRepository<Applicant>, IAsyncRepository<Applicant>
    {
        // Entity'ye özel metotlar buraya eklenebilir
    }
}