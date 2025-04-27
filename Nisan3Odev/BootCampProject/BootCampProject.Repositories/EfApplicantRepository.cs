using BootCampProject.Core.Repositories.EntityFramework;
using BootCampProject.Entities;
using BootCampProject.Repositories.Abstracts;
using BootCampProject.Repositories.Contexts;

namespace BootCampProject.Repositories.Concretes.EntityFramework
{
    public class EfApplicantRepository : EfRepositoryBase<Applicant, BootCampProjectContext>, IApplicantRepository
    {
        // Özel implementasyonlar burada olabilir
    }
}
