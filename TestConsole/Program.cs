using System;
using WundergroundAPI;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
			var wApi = new WApi("26d9937d4080f167");
			var forecast = wApi.GetForecast("hu", "Zalaegerszeg", "HU");
			Console.WriteLine("Day: {0}", forecast.Forecast.Txt_Forecast.ForecastDay[0].FctText_Metric);
			Console.WriteLine("Night: {0}", forecast.Forecast.Txt_Forecast.ForecastDay[1].FctText_Metric);
            Console.ReadLine();
        }
    }
}
