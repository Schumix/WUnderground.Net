using System;

namespace CGurus.Weather.WundergroundAPI.Models
{
	public class Forecast
	{
		public SimpleForecast SimpleForecast { get; set; }
		public TxtForecast Txt_Forecast { get; set; }
	}
}
