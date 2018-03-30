using Microsoft.AspNetCore.Mvc;

namespace Betabit.Weather.WebApp.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "0622847811";
        }

        public string Address()
        {
            return "Veghel";
        }
    }
}
