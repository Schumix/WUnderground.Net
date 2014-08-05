using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace CGurus.Weather.WundergroundAPI.Utilities
{
	internal class RestRequest
	{
		internal static T Execute<T>(string Uri) where T : new()
		{
			return JsonConvert.DeserializeObject<T>(GetUrl(Uri), new Utilities.BoolConverter(), new Utilities.DoubleConverter());
		}

		internal static string GetUrl(string url)
		{
			var request = (HttpWebRequest)WebRequest.Create(url);
			request.AllowAutoRedirect = true;

			int length = 0;
			byte[] buf = new byte[1024];
			var sb = new StringBuilder();

			using(var response = (HttpWebResponse)request.GetResponse())
			{
				using(var stream = response.GetResponseStream())
				{
					while((length = stream.Read(buf, 0, buf.Length)) != 0)
					{
						buf = Encoding.Convert(Encoding.GetEncoding(response.CharacterSet), Encoding.UTF8, buf);
						sb.Append(Encoding.UTF8.GetString(buf, 0, length));
					}
				}
			}

			buf = null;

			return sb.ToString();
		}
	}
}
