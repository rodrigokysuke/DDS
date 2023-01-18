using App.Models.Entities;

namespace App.Models.Repositories
{
    internal class EmployeeRepository
    {
        private static readonly DdsDbContext ddsDbContext;

        static EmployeeRepository()
        {
            ddsDbContext = new DdsDbContext();
        }

        internal static List<Employee> GetAllEmployees()
        {
            return ddsDbContext.Employees.ToList();
        }

        internal static Employee? GetEmployeeByLoginData(string? registration, string? password)
        {
            return ddsDbContext.Employees.FirstOrDefault(e => e.Registration == registration && e.Password == password);
        }
    }
}
