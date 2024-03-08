using ANC_WAPI_EmployeeApi.Models;
using ANC_WAPI_EmployeeApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ANC_WAPI_EmployeeApi.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class SoapAdapterController : ControllerBase
    {
        private readonly EmployeeSoapService _employeeSoapService;

        public SoapAdapterController(EmployeeSoapService employeeSoapService)
        {
            _employeeSoapService = employeeSoapService;
        }

        [HttpPost("add")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeSoapService.AddEmployee(employee);
            return Ok();
        }

        [HttpGet("byname/{name}")]
        public IActionResult GetEmployeesByName(string name)
        {
            var employees = _employeeSoapService.GetEmployeesByName(name);
            return Ok(employees);
        }

        [HttpGet("bydepartment/{department}")]
        public IActionResult GetEmployeesByDepartment(string department)
        {
            var employees = _employeeSoapService.GetEmployeesByDepartment(department);
            return Ok(employees);
        }
    }
}
