using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using Proyecto.Modelos;
using Newtonsoft.Json;


namespace Proyecto.Modelos
{
    public class WheatherData
    {
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }
                
    }

    public class Wind
    {
        [JsonProperty("speed")]

        public double Speed { get; set; }
    }
}