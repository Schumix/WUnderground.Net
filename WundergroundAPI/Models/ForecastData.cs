using System;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class ForecastData
    {
        public Forecast Forecast { get; set; }
        public Response Response { get; set; }
    }
}
