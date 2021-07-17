using DevopsPractice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsPractice.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult(new
            {
                nombre="Daniel Jimenez",
                matricula= "1084357"
            });
        }
    }
}
