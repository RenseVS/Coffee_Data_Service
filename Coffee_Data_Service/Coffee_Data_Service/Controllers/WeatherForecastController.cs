using Coffee_Data_Service.DTOs;
using Coffee_Data_Service.Entities;
using Coffee_Data_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Data_Service.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly CoffeeMadeService service1;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, CoffeeMadeService service)
    {
        _logger = logger;
        service1 = service;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        service1.AddCoffee(new Coffee(new CoffeeDTO()
        {
            MachineID = "6368fb431e737543aa41a34a",
            WaterMililiter = 10
        }));
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

