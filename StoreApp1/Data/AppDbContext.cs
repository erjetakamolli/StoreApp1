using Microsoft.EntityFrameworkCore;
using StoreApp1.Models;

namespace StoreApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>().HasData(

                 new Employee
                 {
                     Id = 1,
                     FirstName = "Erjeta",
                     LastName = "Kamolli",
                     Dept = "300",
                     Address = "Jordan Misja",
                     IsActive = true,
                     DateOfBirth = DateTime.Now.AddYears(-20),
                     Position = 1,
                     ModifiedDate = DateTime.Now,


                 });

        }

    }

}

