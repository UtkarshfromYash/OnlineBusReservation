using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models.Models;
public class Route
    {
        [Key]
        public int RouteID { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
        public decimal Distance { get; set; }
        public decimal BaseFare { get; set; }
    }