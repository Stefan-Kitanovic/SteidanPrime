﻿using Newtonsoft.Json;

namespace SteidanPrime
{
    public enum ApplicationRunningMethod
    {
        Service,
        Console
    }

    public class Settings
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        
        [JsonProperty("prefix")]
        public string CommandPrefix { get; set; }
        public string Owner { get; set; }
        public bool AutoReconnect { get; set; }

        public ApplicationRunningMethod ApplicationRunningMethod { get; set; }
    }
}
