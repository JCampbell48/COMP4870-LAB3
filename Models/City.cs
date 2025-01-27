using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityApp.Models
{
    public class City
    {   [Key]
        public int? CityId { get; set; }
        public string? CityName { get; set; }
        public int? Population { get; set; }
        [Required]
        public string? ProvinceCode { get; set; } 
    }
}