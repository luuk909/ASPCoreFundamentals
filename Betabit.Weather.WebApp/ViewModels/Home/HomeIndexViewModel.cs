﻿using Betabit.Weather.WebApp.Models;
using System.Collections.Generic;

namespace Betabit.Weather.WebApp.ViewModels.Home
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentMessage { get; set; }
    }
}
