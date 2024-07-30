using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace SampleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public async Task<ActionResult> RandomMethod()
        {
            string name = "Abhi";
            return Ok(new {message = "okok"});
        }
        public async Task<ActionResult> RandomMethod1()
        {
            string name = "Abhi";
            return Ok(new { message = "okok" });
        }
        public async Task<ActionResult> RandomMethod2()
        {
            string name = "Abhi";
            return Ok(new { message = "okok" });
        }
    }
}
