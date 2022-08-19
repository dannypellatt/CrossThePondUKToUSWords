using System;
using System.ComponentModel.DataAnnotations;

namespace CrossThePondUKToUSWords.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "City name is empty!")]
        [Display(Name = "City Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Invalid input. Length must be between 2 to 30 characters.")]

        public string CityName { get; set; }
    }   
}

