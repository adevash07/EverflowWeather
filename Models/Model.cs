 using Newtonsoft.Json;

namespace EverFlowWeather.Models;

public class Main
{
    public double temp { get; set; }
    public double feels_like { get; set; }
    public double temp_min { get; set; }
    public double temp_max { get; set; }
    public int pressure { get; set; }
    public int sea_level { get; set; }
    public int grnd_level { get; set; }
    public int humidity { get; set; }
    public double temp_kf { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string? main { get; set; }
    public string? description { get; set; }
    public string? icon { get; set; }
}

public class Clouds
{
    public int all { get; set; }
}

public class Wind
{
    public double speed { get; set; }
    public int deg { get; set; }
    public double gust { get; set; }
}

public class Rain
{
    public double __invalid_name__3h { get; set; }
}

public class Sys
{
    public string? pod { get; set; }
}

public class Forecast
{
    [JsonProperty("dt")]
    public int Dt { get; set; }
    [JsonProperty("main")]
    public Main? Main { get; set; }
    [JsonProperty("weather")]
    public List<Weather>? Weather { get; set; }
    [JsonProperty("clouds")]
    public Clouds? Clouds { get; set; }
    [JsonProperty("wind")]
    public Wind? Wind { get; set; }
    [JsonProperty("visibility")]
    public int Visibility { get; set; }
    [JsonProperty("pop")]
    public double Pop { get; set; }
    [JsonProperty("rain")]
    public Rain? Rain { get; set; }
    [JsonProperty("sys")]
    public Sys? Sys { get; set; }
    [JsonProperty("dt_txt")]
    public string? DtTxt { get; set; }
}

public class root
{
    public string? cod { get; set; }
    public int message { get; set; }
    public int cnt { get; set; }
    public List<Forecast>? list { get; set; }
}

  // Define a class that represents the geo response object
    public class GeoResponse
    {
        public string? name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
    }