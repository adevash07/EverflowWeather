using Newtonsoft.Json;

namespace EverFlowWeather.Models
{
    public class Weather
    {
        [JsonProperty]
        public double Temperature { get; set; }
        [JsonProperty]
        public string WeatherDescription { get; set; } = " ";
        [JsonProperty]
        public string IconUrl { get; set; } = " ";
        [JsonProperty]
        public DateTime Date { get; set; }
    }
}
