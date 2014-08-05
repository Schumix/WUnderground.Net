using System;

namespace CGurus.Weather.WundergroundAPI.Models
{
	public class Alert
	{
		public string Date { get; set; }
		public long Date_Epoch { get; set; }
		public DateTime Date_EpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.Date_Epoch); } }
		public string Description { get; set; }
		public string Expires { get; set; }
		public long Expires_Epoch { get; set; }
		public DateTime Expires_EpochDate { get { return Utilities.EpochConverter.FromUnixTime(this.Expires_Epoch); } }
		public string Message { get; set; }
		public string Phenomena { get; set; }
		public string Significance { get; set; }
		public string Type { get; set; }
	}
}
