using System;

namespace CGurus.Weather.WundergroundAPI.Utilities
{
    internal class EpochConverter
    {
        internal static DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }
    }
}
