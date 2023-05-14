using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;


namespace EverFlowWeather.Services
{
    public class AppState
    {
        [JsonProperty]
        public int TimetoLiveSeconds { get; set; } = 60;

        public DateTime LastAccessed { get; set; } = DateTime.Now;

        // The property that holds the search input
        [JsonProperty]
        public string SearchInput { get; private set; } = "";

        // The property that holds the array of forecast
        [JsonProperty]
        public List<Weather> Forecast { get; private set; } = new List<Weather>();
     // The class that represents a forecast object
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
         // The method that updates the search input
        public void UpdateSearchInput(ComponentBase Source, string SearchInput)
        {
        this.SearchInput = SearchInput;
        NotifyStateChanged(Source, "SearchInput");
        }

        // The method that updates the array of forecast
        public void UpdateForecast(ComponentBase Source, List<Weather> Forecast)
        {
        this.Forecast = Forecast;
        NotifyStateChanged(Source, "Forecast");
        }

        public event Action<ComponentBase, string> StateChanged;

        private void NotifyStateChanged(ComponentBase Source, string Property) => StateChanged?.Invoke(Source, Property);
 }

}