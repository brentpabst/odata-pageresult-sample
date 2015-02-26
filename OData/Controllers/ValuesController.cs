using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;

namespace OData.Controllers
{
    public class ValuesController : ApiController
    {
        readonly string[] _samples = { "value1", "value2", "more", "more", "more", "more", "more", "more" };

        // GET api/values
        [EnableQuery]
        public PageResult<string> GetFeed()
        {
            return new PageResult<string>(_samples, null, _samples.Count());
        }
    }
}
