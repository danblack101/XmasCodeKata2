using System.Web.Http;

namespace XmasCodeKata.Controllers
{
    public class XmasController : ApiController
    {
        public string OnTheNthDay(int day)
        {
            return "A Partridge in a pear Tree";
        }

    }
}