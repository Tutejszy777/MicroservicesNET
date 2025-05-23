﻿using System.ComponentModel.DataAnnotations;

namespace MicroservicePlatfrom.Models
{
    public class Platform
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
