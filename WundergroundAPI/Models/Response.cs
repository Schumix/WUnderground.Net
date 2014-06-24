using System;
using System.Collections.Generic;

namespace CGurus.Weather.WundergroundAPI.Models
{
    public class Response
    {
        public Dictionary<string, string> Features { get; set; }
        public string TermsOfService { get; set; }
        public string Version { get; set; }
        public Dictionary<string, string> Error { get; set; }
    }
}
