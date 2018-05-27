using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SpeedTest.Controllers
{
    [Route("[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "test";
        }

        ////// GET api/values/5
        ////[HttpGet("{id}")]
        ////public long Get(long id)
        ////{
        ////    return Fibo.fibo(id);
        ////}

        ////// POST api/values
        ////[HttpPost]
        ////public void Post([FromBody]string value)
        ////{
        ////}

        ////// PUT api/values/5
        ////[HttpPut("{id}")]
        ////public void Put(int id, [FromBody]string value)
        ////{
        ////}

        ////// DELETE api/values/5
        ////[HttpDelete("{id}")]
        ////public void Delete(int id)
        ////{
        ////}
    }
}
