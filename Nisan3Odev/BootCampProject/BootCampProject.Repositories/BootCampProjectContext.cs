// BootCampProjectContext.cs
using BootCampProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BootCampProject.Repositories.Contexts
{
    public class BootCampProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BootCampProjectDb;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}