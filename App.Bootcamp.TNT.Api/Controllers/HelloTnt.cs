using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace App.Bootcamp.TNT.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloTntController : ControllerBase
    {
        [HttpGet]
        public string GetMsg(string msg)
        {
            return "Hello TNT Starts Boot Camp =) Dominaremos o Mundo! "+msg;
        }
    }
}