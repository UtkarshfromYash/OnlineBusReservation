using BlazorProject.Models.Models;

public class BookingService:IBookingService
{
    private readonly IBookingRepository _bookingRepository;
    public BookingService(IBookingRepository bookingRepository)
    {
       _bookingRepository=bookingRepository;
    }

    public async Task<Booking> AddBooking(Booking booking)
    {
        return await _bookingRepository.AddBooking(booking);
    }

    public async Task<Booking> GetBookingByUserId(int userId)
    {
        return await _bookingRepository.GetBookingByUserId(userId);
    }

    public Task<IEnumerable<Booking>> GetBookings()
    {
        throw new NotImplementedException();
    }

    public Task<Booking> UpdateBooking(int id, Booking booking)
    {
        return _bookingRepository.UpdateBooking(id,booking);
    }

    public Task<bool> UpdatePaymentStatus(int id, string updatedpaymentStatus)
    {
        return _bookingRepository.UpdatePaymentStatus(id,updatedpaymentStatus);
    }
}