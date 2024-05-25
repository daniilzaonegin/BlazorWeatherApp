namespace BlazorWeatherApp.Shared;

public interface IWeatherService
{
    Task<WeatherForecast[]?> GetWeatherForecastsAsync();
}