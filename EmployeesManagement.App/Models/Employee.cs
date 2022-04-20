using System;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagement.App.Models
{
    //POCO
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DateOfBirth { get; set; }

        public decimal Salary { get; set; }
    }

    ////Data Context
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }
    }
}
