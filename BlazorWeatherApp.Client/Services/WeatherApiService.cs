using System.Net.Http.Json;
using BlazorWeatherApp.Shared;

namespace BlazorWeatherApp.Client.Services;

public class ClientWeatherService: IWeatherService
{
    private readonly HttpClient _http;

    public ClientWeatherService(HttpClient http)
    {
        _http = http;
    }

    public Task<WeatherForecast[]?> GetWeatherForecastsAsync()
    {
        return _http.GetFromJsonAsync<WeatherForecast[]?>("WeatherForecast");
    }
}