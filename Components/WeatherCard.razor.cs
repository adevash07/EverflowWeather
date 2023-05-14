namespace EverFlowWeather.Components;
using Microsoft.AspNetCore.Components;
// A class to represent a weather card component

public partial class WeatherCard : ComponentBase // This should match the component name

{
    // Properties to bind to the component parameters
    [Parameter]
    public String customClass { get; set; } = " ";
    [Parameter]
    public decimal Temperature { get; set; } = 23.30M;
    [Parameter]
    public string WeatherDescription { get; set; } = "Sunny";
    [Parameter]
    public string IconUrl { get; set; } = " ";
    [Parameter]
    public DateTime Date { get; set; }

    // A method to format the date as a string
    public string GetFormattedDate()
    {
        return Date.ToString("d, MMMM dddd");
    }
}
