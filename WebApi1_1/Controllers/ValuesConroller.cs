using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi1_1.Controllers
{

    [Route("api/[controller]")]
    public class ValuesConroller:ApiController
    {
        List<string> strings = new List<string>()
        {
             "value1", "Value2","Value3"
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return strings;
        }

        public string Get(int id )
        {
            return strings[id];
        }

    }
}
