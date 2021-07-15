using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsPractice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public ActionResult<string> Sum([FromQuery] int num1, [FromQuery] int num2)
        {
            var calc = new Calculator();
            double? result;

            var success = calc.Add(num1, num2, out result);

            if (success)
                return result.ToString();
            else
                return "Invalid";
        }
    }
}
