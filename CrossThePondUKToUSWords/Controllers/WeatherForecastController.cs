using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrossThePondUKToUSWords.Models;
using CrossThePondUKToUSWords.OpenWeatherMapModel;
using CrossThePondUKToUSWords.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CrossThePondUKToUSWords.Controllers
{
    public class WeatherForecastController : Controller
    {
        private readonly IWForecastRepository _WForecastRepository;

        public WeatherForecastController(IWForecastRepository WForecastRepository)
        {

            _WForecastRepository = WForecastRepository;
        }

        [HttpGet]
        // GET: /<controller>/
        public IActionResult SearchByCity()
        {
            var viewModel = new SearchByCity();
            return View();
        }

        [HttpPost]
        public IActionResult SearchByCity(SearchByCity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherForecast", new { city = model.CityName });
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult City(string city)
        {
            WeatherResponse weatherResponse = _WForecastRepository.GetForecast(city);
            City viewModel = new City();
            if(weatherResponse != null)
            {
                viewModel.Name = weatherResponse.Name;
                viewModel.Temperature = weatherResponse.Main.Temp;
                viewModel.Humidity = weatherResponse.Main.Humidity;
                viewModel.Weather = weatherResponse.Weather[0].Main;
             

            }
            return View(viewModel);
        }

    }
}

