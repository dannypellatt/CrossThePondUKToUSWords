using System;
using CrossThePondUKToUSWords.OpenWeatherMapModel;

namespace CrossThePondUKToUSWords.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
        WeatherResponse GetForecastLondon(string city);
        WeatherResponse GetForecastDC(string city);
    }
}

