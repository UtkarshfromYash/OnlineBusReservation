using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models.Models;
public class BusSchedule
    {
        [Key]
        public int ScheduleID { get; set; }
        public int BusID { get; set; }
        public int RouteID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AvailableSeats { get; set; }
        public decimal FareAmount { get; set; }
    }