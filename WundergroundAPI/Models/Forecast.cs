using System;

namespace WundergroundAPI.Models
{
	public class Forecast
	{
		public SimpleForecast SimpleForecast { get; set; }
		public TxtForecast Txt_Forecast { get; set; }
	}
}
