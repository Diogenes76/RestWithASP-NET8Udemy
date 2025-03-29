using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNET8Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {       

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fistNumber}/{secondNumber}")]
        public IActionResult Get(string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fistNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");        
        }

        [HttpGet("sub/{fistNumber}/{secondNumber}")]
        public IActionResult Subtraction(string fistNumber, string secondNumber)
        {
            if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(fistNumber) - ConvertToDecimal(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string v_Number)
        {
            double number;
            if (double.TryParse(v_Number, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo, out number)) return true;
            return false;
        }

        private Decimal ConvertToDecimal(string v_Number)
        {
            return Decimal.Parse(v_Number);
        }

      
    }
}
