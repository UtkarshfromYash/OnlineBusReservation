namespace BlazorProject.Models.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public DateOnly DateofBirth { get; set; }
        public string Gender { get; set; }
        public decimal WalletBalance { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public bool IsActive { get; set; } = true;
        public string Role { get; set; }="Customer";
    }
}