using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace First_Api.Controllers
{//[Route ("api/data")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value","" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            getSpeac ob = new getSpeac();
            string value = ob.GetSpecById(id);
            return value ;
        }
        // GET api/values/5
        public List<string> Get(string Name)
        {
            getSpeac ob = new getSpeac();
            List<string> value = ob.GetSpecByName(Name);
            return value;
        }
        // [Route("api/data/User")]
        [HttpGet]
        public string User(string name,int id)
        {
            string a = name + "  " + id;
            return a;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
