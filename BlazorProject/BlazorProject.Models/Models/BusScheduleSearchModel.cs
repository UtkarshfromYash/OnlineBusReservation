using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Models.Models
{
    [Keyless]
    public class BusScheduleSearchModel
    {
        public string Source { get; set; }
        public string Destination { get; set; }
    }
}