using DevopsPractice.Services;
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
        public IActionResult Sum([FromQuery] int num1, [FromQuery] int num2)
        {
            var calc = new Calculator();
            double? result;

            var success = calc.Add(num1, num2, out result);

            if (success)
                return new JsonResult(new {result=result});
            else
                return new JsonResult(new {result="Invalid"});
        }

        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] int num1, [FromQuery] int num2)
        {
            var calc = new Calculator();
            double? result;

            var success = calc.Subtract(num1, num2, out result);

            if (success)
                return new JsonResult(new {result=result});
            else
                return new JsonResult(new {result="Invalid"});
        }

        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] int num1, [FromQuery] int num2)
        {
            var calc = new Calculator();
            double? result;

            var success = calc.Multiply(num1, num2, out result);

            if (success)
                return new JsonResult(new {result=result});
            else
                return new JsonResult(new {result="Invalid"});
        }
    }
}
