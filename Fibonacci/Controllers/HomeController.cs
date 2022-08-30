using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci.Controllers
{
    [ApiController]    
    [Route("[controller]")]
    public class HomeController : Controller
    {        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 1; i < id; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

            return c.ToString();

        }
    }
}
