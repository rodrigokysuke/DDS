using App.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Models
{
    internal class DdsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite("Data Source=dds.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Registration = "admin",
                    Password = "_dds@adm!2023",
                    Name = "Administrador do sistema",
                    Role = Enums.Role.Administrator,
                    Signature = string.Empty
                }
            );
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<Session> Session { get; set; }
    }
}
