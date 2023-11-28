using Microsoft.AspNetCore.Mvc;

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
            return "evday agicmay isyay osay easyyay , iyay ovelay ityay ! it'syay efinitelyday otnay ayay opycay andyay astepay ofyay igpay atinlay!".DevMagicToEnglish();
       
        }

  
    }
}
