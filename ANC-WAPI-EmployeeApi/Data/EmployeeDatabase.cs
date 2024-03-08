using ANC_WAPI_EmployeeApi.Models;

namespace ANC_WAPI_EmployeeApi.Data
{
    public class EmployeeDatabase
    {
        private readonly AppDbContext _context;

        public EmployeeDatabase(AppDbContext context)
        {
            _context = context;
        }

        public void AddEmployeeToDatabase(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetEmployeesByNameFromDatabase(string name)
        {
            return _context.Employees
                .Where(e => e.Name == name)
                .ToList();
        }

        public List<Employee> GetEmployeesByDepartmentFromDatabase(string department)
        {
            return _context.Employees
                .Where(e => e.Department == department)
                .ToList();
        }
    }
}
