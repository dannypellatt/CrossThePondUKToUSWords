using System;
using CrossThePondUKToUSWords.OpenWeatherMapModel;

namespace CrossThePondUKToUSWords.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
        WeatherResponse GetForecastImperial(string city);
    }
}

