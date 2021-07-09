using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SecretsManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretsManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration configuration;
        private readonly TestSettings testSettings;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
            
            testSettings = new TestSettings();
            configuration.GetSection("Test").Bind(testSettings);
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("third-level-setting")]
        public ActionResult<string> GetThirdLevelSetting()
        {
            return configuration.GetValue<string>("FirstLevelSetting:SecondLevelSetting:LastLevelSetting");
        }

        [HttpGet("third-level-setting/better-way")]
        public ActionResult<string> GetThirdLevelSettingBetterWay()
        {
            var firstLevelSettingSection = configuration.GetSection("FirstLevelSetting");
            var secondLevelSettingSection = firstLevelSettingSection.GetSection("SecondLevelSetting");
            var lastLevelSettingSection = secondLevelSettingSection.GetSection("LastLevelSetting");
            return lastLevelSettingSection.Value;
        }

        [HttpGet("get-binded-settings")]
        public ActionResult<string> GetBindedSettings()
        {
            return testSettings.PhoneNumber;
        }
    }
}
