using System.Net.Http.Json;
using EverFlowWeather.Models;

public class WeatherService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public WeatherService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    // Define the API key and base address for open weather
    // Get the API key from the appsettings.json file
    private string? ApiKey => _configuration.GetSection("OpenWeatherApiKey").Value;
    private const string BaseAddress = "http://api.openweathermap.org";

    // Define a method that gets the latitude and longitude for a city name
    public async Task<(double lat, double lon)> GetLatLonAsync(string city)
    {
        // Build the request URL with the city name and API key
        var requestUrl = $"{BaseAddress}/geo/1.0/direct?q={city}&limit=5&appid={ApiKey}";

        // Make a GET request and get the response as a JSON array
        var response = await _httpClient.GetFromJsonAsync<GeoResponse[]>(requestUrl);

        // Check if the response is not null or empty
        if (response != null && response.Length > 0)
        {
            // Return the first item's latitude and longitude as a tuple
            return (response[0].lat, response[0].lon);
        }
        else
        {
            // Throw an exception if no results are found
            throw new Exception("No results found for the city name");
        }
    }
    // Define a method that gets the five day weather forecast for a latitude and longitude
    public async Task<List<Weather>> GetForecastAsync(double lat, double lon)
    {
        // Build the request URL with the latitude, longitude and API key
        var requestUrl = $"{BaseAddress}/data/2.5/forecast?lat={lat}&lon={lon}&appid={ApiKey}";

        // Make a GET request and get the response as a JSON object
        var response = await _httpClient.GetFromJsonAsync<Forecast>(requestUrl);

        // Check if the response is not null
        if (response != null && response.list != null)
        {
            // Return the list of forecasts as a list of Forecast objects
            return response.list;
        }
        else
        {
            // Throw an exception if no results are found
            throw new Exception("No results found for the coordinates");
        }
    }

    // Define a class that represents the geo response object
    public class GeoResponse
    {
        public string? name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
    }

    // Define a class that represents the forecast response object
    public class Forecast
    {
        public List<Weather>? list { get; set; }
    }
}