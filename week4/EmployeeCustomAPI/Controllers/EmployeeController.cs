using Microsoft.AspNetCore.Mvc;
using EmployeeCustomAPI.Models;
using EmployeeCustomAPI.Filters;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeCustomAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[ServiceFilter(typeof(CustomAuthFilter))]
public class EmployeeController : ControllerBase
{
    private static List<Employee> _employees = new List<Employee>
    {
        new Employee
        {
            Id = 1,
            Name = "Alice",
            Salary = 60000,
            Permanent = true,
            Department = new Department { Id = 1, Name = "HR" },
            Skills = new List<Skill>
            {
                new Skill { Id = 1, Name = "Communication" },
                new Skill { Id = 2, Name = "Recruitment" }
            },
            DateOfBirth = new DateTime(1990, 1, 1)
        }
    };

    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<Employee>> GetStandard()
    {
        return Ok(_employees);
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        _employees.Add(employee);
        return Ok(employee);
    }

    // ✅ NEW: PUT method to update employee
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(Employee), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var employee = _employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return BadRequest("Invalid employee id");
        }

        // Update the employee
        employee.Name = updatedEmployee.Name;
        employee.Salary = updatedEmployee.Salary;
        employee.Permanent = updatedEmployee.Permanent;
        employee.Department = updatedEmployee.Department;
        employee.Skills = updatedEmployee.Skills;
        employee.DateOfBirth = updatedEmployee.DateOfBirth;

        return Ok(employee);
    }
}
