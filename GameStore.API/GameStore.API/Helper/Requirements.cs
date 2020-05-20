using GameStore.API.Models;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Helper
{
    public class Requirements
    {
        [Required]
        public double Size { get; set; }
        [Required]
        public OS OperatingSystem { get; set; }
        [Required]
        public int Ram { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public string GPU { get; set; }
        [Required]
        public Platform Platform { get; set; }

    }
}
