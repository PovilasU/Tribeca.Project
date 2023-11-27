using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tribeca.WebAPI.Controllers;
using Tribeca.WebAPI.Services.Implementation;
using Tribeca.WebAPI.Services.Interfaces;

namespace Tribeca.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
 
        private readonly IEmployeeService employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {

            this.employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = employeeService.GetAllEmployees();

            // Transform the employees to include the extra field
            var employeesWithExtraField = employees.Select(employee => new EmployeeDevMagic
            {
                EmployeeId = employee.EmployeeID,
                ClientID = employee.ClientID,
                OfficeID = employee.OfficeID,
                EmployeeName = employee.Name,
                Bio = employee.Bio,
                DateOfBirth = employee.DateOfBirth,                
                StarSign = employee.DateOfBirth.ToString().StarSign(), 
                BioAsDevMagic = "BioAsDevMagic".EnglishToDevMagic() 
            });

            return Ok(employeesWithExtraField);

        }


    }
}








