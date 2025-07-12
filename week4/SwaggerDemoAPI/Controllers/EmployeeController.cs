using Microsoft.AspNetCore.Mvc;
using SwaggerDemoAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerDemoAPI.Controllers
{
    [ApiController]
    [Route("api/emp")] // changed from controller name to a custom route
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "IT", Salary = 60000 }
        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetEmployees() => Ok(employees);

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetEmployeeById(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            return Ok(emp);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateEmployee(Employee emp)
        {
            employees.Add(emp);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = emp.Id }, emp);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateEmployee(int id, Employee updated)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            emp.Name = updated.Name;
            emp.Department = updated.Department;
            emp.Salary = updated.Salary;
            return Ok(emp);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteEmployee(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            employees.Remove(emp);
            return NoContent();
        }
    }
}
