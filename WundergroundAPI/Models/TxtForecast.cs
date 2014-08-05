using System;

namespace WundergroundAPI.Models
{
	public class TxtForecast
	{
		public string Date { get; set; }
		public ForecastDay[] ForecastDay { get; set; }
	}
}
