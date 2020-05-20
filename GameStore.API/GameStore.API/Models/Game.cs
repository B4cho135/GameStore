using GameStore.API.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.API.Models
{
    public enum Platform
    {
        PC,
        XBOX,
        Playstation,
        Nintendo
    }
    public enum OS 
    {
        Windows_XP,
        Windows_7,
        Windows_8,
        Windows_10,
        Linux,
        MAC
    }
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string InterfaceLanguage { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public Requirements Requirements { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
