﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using Tribeca.WebAPI.Entities;
using Tribeca.WebAPI.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tribeca.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevMagicController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
     
            IDevMagicService devMagicService = new DevMagicService();          
            string devmagicStr = "evday agicmay isyay osay easyyay , iyay ovelay ityay ! it'syay efinitelyday otnay ayay opycay andyay astepay ofyay igpay atinlay!";
            return devMagicService.TransformFromDevMagic(devmagicStr);         
        }
    }
}
