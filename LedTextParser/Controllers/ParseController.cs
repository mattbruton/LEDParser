using LedTextParser.Parser;
using System.Web.Http;

namespace LedTextParser.Controllers
{
    public class ParseController : ApiController
    {
        // POST api/<controller>
        public string Post([FromBody]string value)
        {
            RepStringConverter rsc = new RepStringConverter();
            return rsc.ConvertRep(value);
        }
    }
}