using BlazorProject.Models.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BookingController:ControllerBase
{
    private readonly IBookingService _bookingService;
    public BookingController(IBookingService bookingService)
    {
        _bookingService=bookingService;
    }

    [HttpPost]
    public async Task<ActionResult<Booking>> AddBooking(Booking booking)
    {
        booking.BookingDate=DateTime.Now;
        var newBooking=await _bookingService.AddBooking(booking);
        if(ModelState.IsValid) return Ok(newBooking);
        else return BadRequest(ModelState);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Booking>> UpdateBooking(int id,Booking booking)
    {
        var updatedBooking=await _bookingService.UpdateBooking(id,booking);
        if(ModelState.IsValid) return Ok(updatedBooking);
        else return BadRequest(ModelState);
    }

    [HttpPut("{id}/{updatedpaymentStatus}")]
    public async Task<ActionResult<bool>> UpdatePaymentStatus(int id,string updatedpaymentStatus)
    {
        var result=await _bookingService.UpdatePaymentStatus(id,updatedpaymentStatus);
        if(result) return Ok(result);
        else return NotFound();
    }
}