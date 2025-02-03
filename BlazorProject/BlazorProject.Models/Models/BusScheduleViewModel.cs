using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Models.Models;
[Keyless]
public class BusScheduleViewModel
{
    public int ScheduleID {get;set;}
    public string Source { get; set; }
    public string Destination { get; set; }
    public decimal Distance { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int AvailableSeats { get; set; }
    public decimal FareAmount { get; set; }
    public string BusName { get; set; }
    public string BusType { get; set; }
    public int TotalSeats { get; set; }
    public string Features { get; set; }

    // Additional computed properties
    public TimeSpan JourneyDuration => ArrivalTime - DepartureTime;
    public string DepartureTimeFormatted => DepartureTime.ToString("dd-MM-yyyy hh:mm tt");
    public string ArrivalTimeFormatted => ArrivalTime.ToString("dd-MM-yyyy hh:mm tt");
    public string FareFormatted => $"₹{FareAmount:N2}";
}