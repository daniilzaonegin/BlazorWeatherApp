using BlazorWeatherApp.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWeatherApp.Controller;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public Task<WeatherForecast[]?> Get()
    {
        return _weatherService.GetWeatherForecastsAsync();
    }
}