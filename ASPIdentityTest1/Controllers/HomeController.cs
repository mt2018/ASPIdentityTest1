using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPIdentityTest1.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace ASPIdentityTest1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("[action]/{city}")]
        public async Task<IActionResult> About(string city)
        {
            //ViewData["Message"] = "Your application description page.";

           // return View();

            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://api.openweathermap.org");
                        var response = await client.GetAsync($"/data/2.5/weather?q={city}&appid=a8e346ed999ce49034397d05a9ffdba7&units=metric");
                        response.EnsureSuccessStatusCode();

                        var stringResult = await response.Content.ReadAsStringAsync();
                        var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);
                        //return Ok(new
                        //{
                        //    Temp = rawWeather.Main.Temp,
                        //    Summary = string.Join(",", rawWeather.Weather.Select(x => x.Main)),
                        //    City = rawWeather.Name
                        //});
                        return View(rawWeather);
                    }
                    catch (HttpRequestException httpRequestException)
                    {
                        return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                    }
                }
            }
        }

        public class OpenWeatherResponse
        {
            public string Name { get; set; }

            public IEnumerable<WeatherDescription> Weather { get; set; }

            public Main Main { get; set; }
        }

        public class WeatherDescription
        {
            public string Main { get; set; }
            public string Description { get; set; }
        }

        public class Main
        {
            public string Temp { get; set; }
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
