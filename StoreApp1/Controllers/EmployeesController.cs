using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreApp1.Data;
using StoreApp1.Models;
using StoreApp1.Services;
using StoreApp1.View;


namespace StoreApp1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeeService _employeeservice;

        public EmployeesController(EmployeeService employeeservice)
        {
            _employeeservice = employeeservice;
        }

        [HttpGet("get-all-employees")]
        public IActionResult GetAllEmployees()
        {
            var allemployees = _employeeservice.GetAllEmployees();
            return Ok(allemployees);
        }

        [HttpGet("get-employees-by-id/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeservice.GetEmployeeById(id);
            return Ok(employee);
        }

        [HttpPost("add-employee")]
        public IActionResult AddEmployee([FromBody] EmployeeVM employee)
        {
            _employeeservice.AddEmployee(employee);
            return Ok();
        }

        [HttpPut("update-employee-id/{id}")]
        public IActionResult UpdateEmployeeById(int id, [FromBody] EmployeeVM employee)
        {
            var updateEmployee = _employeeservice.UpdateEmployeeById(id, employee);
            return Ok(updateEmployee);
        }

        [HttpDelete("delete-employee-by-id/{id}")]

        public IActionResult DeleteEmployeeById(int id)
        {
            _employeeservice.DeleteEmployeeById(id);
            return Ok();
        }
    }
}
