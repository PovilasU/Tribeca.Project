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
            var result = employeeService.GetAllEmployees();
            return Ok(result);
        }


    }
}








