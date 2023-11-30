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
        public IActionResult GetClients()
        {
            var clients = clientService.GetAllClients();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public IActionResult GetClientById(int id)
        {
            var clients = clientService.GetClientById(id);
            return Ok(clients);
        }
    }
}