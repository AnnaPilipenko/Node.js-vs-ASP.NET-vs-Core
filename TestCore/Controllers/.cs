using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpeedTest.Controllers
{
    [Route("[controller]")]
    public class DBController : Controller
    {
        [HttpGet]
        public string Get()
        {
            //var addedTest = Program.context.test.Add(new TestModel
            //{
            //    azaza = Program.rand.Next(0, 1000),
            //});
            //Program.context.SaveChanges();
            //addedTest.Entity.updateTime = (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            //Program.context.SaveChanges();
            return "ok";
        }
    }
}