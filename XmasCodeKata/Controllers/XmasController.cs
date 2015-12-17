using System.Web.Http;

namespace XmasCodeKata.Controllers
{
    public class XmasController : ApiController
    {

        [HttpGet]
        public string OnTheNthDay(int day)
        {
            var carol = new TwelveDaysCarol();
            return carol.Day(day);
        }
    }
}