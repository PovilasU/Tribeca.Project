using Microsoft.AspNetCore.Mvc;
using Tribeca.WebAPI.Helpers;
using Tribeca.WebAPI.Models;
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

            // include StarSign and devMagic bio fields to employees
            var employeesDevMagic = employees.Select(employee => new EmployeeDevMagic
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

            return Ok(employeesDevMagic);


        }

        [HttpGet("{name}")]
        public IActionResult GetEmployeeStarSign(string name)
        {

            var emploeyee = employeeService.GetEmployeeStarSign(name);

            var employeeDevMagic = emploeyee.Select(employee => new EmployeeStarSign
            {
           
                EmployeeName = employee.Name,         
                StarSign = employee.DateOfBirth.ToString().StarSign(),
                
            });


            return Ok(employeeDevMagic.First());




        }
    }
}








