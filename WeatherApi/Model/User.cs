﻿using System.ComponentModel.DataAnnotations;

namespace WeatherApi.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }


        public List<Towns>? FavariteTowns { get; set; }
    }
}
