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
    private readonly List<Employee> _employees;

    public EmployeeController()
    {
        _employees = GetStandardEmployeeList();
    }

    private List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>
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
    }

    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(typeof(List<Employee>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<List<Employee>> GetStandard()
    {
        // Uncomment this to trigger exception for testing
        // throw new Exception("Simulated error");

        return Ok(_employees);
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        // Normally you'd save to DB
        return Ok(employee);
    }
}
