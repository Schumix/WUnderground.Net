﻿using System;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class Wind
    {
        public double? Degrees { get; set; }
        public string Dir { get; set; }
        public double? Kph { get; set; }
        public double? Mph { get; set; }
    }
}
