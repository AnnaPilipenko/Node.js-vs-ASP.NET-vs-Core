using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestCore.Controllers
{
    [Route("[controller]")]
    public class ShaController : Controller
    {
        [HttpGet("{num}")]
        public string Get(long num)
        {
            string str = Guid.NewGuid().ToString();
            HashAlgorithm algorithm = SHA256.Create();
            byte[] hash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(str));
            for (int i = 0; i < num; ++i)
            {
                hash = algorithm.ComputeHash(hash);
            }

            return GetHashString(hash);
        }

        private static string GetHashString(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
