using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Betabit.Weather.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Betabit.Weather.WebApp.ViewComponents
{
    public class GreeterViewComponent : ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheDay();
            return View("Default", model);
        }
    }
}
