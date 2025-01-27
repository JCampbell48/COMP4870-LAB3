using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommunityApp.Models
{
    public class Province
    {
        [Key]
        [Required]
        [StringLength(5, MinimumLength = 2)]
        public string? ProvinceCode { get; set; } // Primary Key

        [Required]
        [StringLength(100)] // Maximum length for province name
        public string? ProvinceName { get; set; }

        public List<City> Cities { get; set; } = new();
    }
}
