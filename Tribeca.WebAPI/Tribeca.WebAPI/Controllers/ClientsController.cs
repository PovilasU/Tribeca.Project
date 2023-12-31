﻿using Microsoft.AspNetCore.Mvc;
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
            var groupedClients = clients
                     .GroupBy(c => c.ClientId)
                     .Select(group => new
                     {
                         ClientId = group.Key,
                         Name = group.First().Name,
                         Offices = group.Select(office => new
                         {
                             OfficeId = office.OfficeID,
                             Address = office.Address,
                             IsHeadOffice = office.IsHeadOffice,
                             EmployeeId = office.EmployeeID,
                             EmployeeName = office.EmployeeName
                         }).ToList()
                     })
                     .ToList();

            return Ok(groupedClients);
        }

        [HttpGet("{id}")]
        public IActionResult GetClientById(int id)
        {
            var clients = clientService.GetClientById(id);
            return Ok(clients);
        }
    }
}