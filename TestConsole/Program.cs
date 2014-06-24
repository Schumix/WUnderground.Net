using System;
using CGurus.Weather.WundergroundAPI;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
			WApi wApi = new WApi("26d9937d4080f167");

			//var alerts = wApi.GetAlerts("hu", "Zalaegerszeg", "HU");
			var forecast = wApi.GetForecast("hu", "Zalaegerszeg", "HU");
			//var forecast10Day = wApi.GetForecast10DayUS("CA", "San Francisco");
			//var forecastHourlyUS = wApi.GetForecastHourlyUS("CA", "San Francisco");
			Console.WriteLine("Nappal: {0}", forecast.Forecast.Txt_Forecast.ForecastDay[0].FctText_Metric);
			Console.WriteLine("Éjszaka: {0}", forecast.Forecast.Txt_Forecast.ForecastDay[1].FctText_Metric);
            Console.ReadLine();
        }
    }
}
