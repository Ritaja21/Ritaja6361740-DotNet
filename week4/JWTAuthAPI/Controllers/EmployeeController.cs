using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using JWTAuthAPI.Models;

namespace JWTAuthAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin,POC")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> _employees = new()
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
                new Skill { Id = 2, Name = "Teamwork" }
            },
            DateOfBirth = new DateTime(1990, 1, 1)
        }
    };

    [HttpGet]
    public ActionResult<List<Employee>> Get() => Ok(_employees);
}
