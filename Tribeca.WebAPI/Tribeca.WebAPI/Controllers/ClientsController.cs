using Microsoft.AspNetCore.Mvc;
using Tribeca.WebAPI.Services.Interfaces;

namespace Tribeca.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
 
        private readonly IClientService clientService;
        public ClientsController(IClientService clientService)
        {

            this.clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var clients = clientService.GetAllClients();


            return Ok(clients);
          

        }


    }
}








