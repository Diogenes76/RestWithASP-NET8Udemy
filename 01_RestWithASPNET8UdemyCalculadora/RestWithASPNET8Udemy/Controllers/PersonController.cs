using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET8Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {       

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fistNumber}/{secondNumber}")]
        public IActionResult Sum(string fistNumber, string secondNumber)
        {            
            return BadRequest("Invalid Input");        
        }   
      
    }
}
