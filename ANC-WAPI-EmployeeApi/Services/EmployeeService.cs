using ANC_WAPI_EmployeeApi.Data;
using ANC_WAPI_EmployeeApi.Models;

namespace ANC_WAPI_EmployeeApi.Services
{
    public class EmployeeService
    {
        private readonly EmployeeDatabase _employeeDatabase;

        public EmployeeService(EmployeeDatabase employeeDatabase)
        {
            _employeeDatabase = employeeDatabase;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeDatabase.AddEmployeeToDatabase(employee);
        }

        public List<Employee> GetEmployeesByName(string name)
        {
            return _employeeDatabase.GetEmployeesByNameFromDatabase(name);
        }

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            return _employeeDatabase.GetEmployeesByDepartmentFromDatabase(department);
        }
    }
}
