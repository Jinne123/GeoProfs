using Geoprofs.Models;
using Microsoft.EntityFrameworkCore;

namespace Geoprofs.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<users> userss { get; set; }
        public DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Absence>().ToTable("Absence");
            modelBuilder.Entity<users>().ToTable("users");
            modelBuilder.Entity<Login>().ToTable("Logins");
        }
    }
}