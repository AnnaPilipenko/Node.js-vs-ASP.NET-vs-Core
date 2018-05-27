using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpeedTest.Controllers
{
    [Route("[controller]")]
    public class AlgController : Controller
    {
        [HttpGet]
        public string Get()
        {
            int a = 0;
            for (int i = 0; i < 10000000; ++i)
            {
                a = i;
            }

            return "ok";
        }
    }
}