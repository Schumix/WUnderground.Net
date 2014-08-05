using System;

namespace CGurus.Weather.WundergroundAPI.Models
{
	public class AlertData
	{
		public Alert[] Alerts { get; set; }
		public Response Response { get; set; }
	}
}
