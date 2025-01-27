using BlazorProject.Models.Models;

public interface IBookingRepository
{
    Task<IEnumerable<Booking>> GetBookings();
    Task<Booking> GetBookingByUserId(int userId);
    Task<Booking> AddBooking(Booking booking);
    Task<Booking> UpdateBooking(int id,Booking booking);
    Task<bool> UpdatePaymentStatus(int id,string updatedpaymentStatus);
}