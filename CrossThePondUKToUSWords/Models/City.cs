﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CrossThePondUKToUSWords.Models
{
    public class City
    {
        [Display(Name = "City Name:")]
        public string Name { get; set; }

        [Display(Name = "Temperature:")]
        public float Temperature { get; set; }

        [Display(Name = "Humidity:")]
        public int Humidity { get; set; }

        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }

    }
}
