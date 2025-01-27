using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models.Models;
public class Booking
{
    [Key]
    public int BookingID { get; set; }
    public int UserId { get; set; }
    public int ScheduleId { get; set; }
    public DateTime BookingDate { get; set; }
    public int TotalTickets { get; set; }=1;
    public decimal TotalAmount { get; set; }
    public string BookingStatus { get; set; }="Confirmed";
    public string PaymentStatus { get; set; }="Pending";

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public string Phone { get; set; }
}