using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Models.Models;
public class Payment
{
      [Key]
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionID { get; set; }
        public DateTime PaymentDate { get; set; }=DateTime.Now;
}