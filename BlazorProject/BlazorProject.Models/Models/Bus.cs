using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models.Models;
public class Bus
{
    [Key]
    public int BusId { get; set; }

    [Required(ErrorMessage = "Bus Name is required")]
    [StringLength(100,ErrorMessage = "Bus Name cannot exceed 100 characters")]
    public string BusName { get; set; }
    [Required(ErrorMessage = "Bus Number is required")]
    public string BusNumber { get; set; }
    [Required(ErrorMessage = "Bus Type is required")]
    public string BusType { get; set; }
    [Required(ErrorMessage = "Total Seats is required")]
    public string TotalSeats { get; set; }
    [Required(ErrorMessage = "Is Bus Driver Available")]
    public string HasDriver { get; set; }
    [Required(ErrorMessage = "Let Us know about the features of the bus")]
    public string Features { get; set; }
}