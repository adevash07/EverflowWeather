using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using EverFlowWeather.Models;


namespace EverFlowWeather.Services
{
    public class AppState
    {
        [JsonProperty]
        public int TimetoLiveSeconds { get; set; } = 60;

        public DateTime LastAccessed { get; set; } = DateTime.Now;

        // The property that holds the search input
        [JsonProperty]
        public string SearchInput { get; set; } = "london";

        // The property that holds the array of Weather(Forecast)
        [JsonProperty]
        public List<Forecast> List { get; set; } = new List<Forecast>();
         // The method that updates the search input
        public void UpdateSearchInput(ComponentBase Source, string SearchInput)
        {
        this.SearchInput = SearchInput;
        NotifyStateChanged(Source, "SearchInput");
        }

        // The method that updates the array of forecast
        public void UpdateForecast(ComponentBase Source, List<Forecast> Forecast)
        {
        this.List = Forecast;
        NotifyStateChanged(Source, "Forecast");
        }

        public event Action<ComponentBase, string>? StateChanged;

        private void NotifyStateChanged(ComponentBase Source, string Property) => StateChanged?.Invoke(Source, Property);
 }

}