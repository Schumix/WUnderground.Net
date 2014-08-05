using System;

namespace CGurus.Weather.WundergroundAPI.Models
{
	public class ForecastHourlyData
	{
		public ForecastHourly[] Hourly_Forecast { get; set; }
		public Response Response { get; set; }
	}
}
