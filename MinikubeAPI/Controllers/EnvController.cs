using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MinikubeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvController : ControllerBase
    {
        // GET api/env
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List<string> output = new List<string>();
            output.Add("Logs:");
            output.Add(string.Format("Machine Name: {0}", Environment.MachineName));
            output.Add(string.Format("OS: {0}", Environment.OSVersion));
            return Ok(output);
        }

        // GET api/env/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/env
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/env/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/env/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
