using System;
using System.Collections.Generic;
using System.Net;

namespace RokuDataObjects
{
    public class Roku
    {
        public string Url { get; set; }
        public IPAddress IPAddress { get; set; }
        public string DeviceName { get; set; }
        public string DisplayName { get; set; }
        public List<RokuApp> Apps { get; set; }
    }
}
