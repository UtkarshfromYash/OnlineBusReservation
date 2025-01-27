using BlazorProject.Models.Models;

public class BookingRepository: IBookingRepository
{
    private readonly AppDbContext _context;
    public BookingRepository(AppDbContext context)
    {
        _context=context;
    }

    public async Task<Booking> AddBooking(Booking booking)
    {
        var result= await _context.Bookings.AddAsync(booking);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public Task<Booking> GetBookingByUserId(int userId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Booking>> GetBookings()
    {
        throw new NotImplementedException();
    }

    public async Task<Booking> UpdateBooking(int id, Booking booking)
    {
        _context.Bookings.Update(booking);
        await _context.SaveChangesAsync();
        return booking;
    }

    public async Task<bool> UpdatePaymentStatus(int id, string updatedpaymentStatus)
    {
        var booking= await _context.Bookings.FindAsync(id);
        if(booking!=null){
            booking.PaymentStatus=updatedpaymentStatus;
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }
}

