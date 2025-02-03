using BlazorProject.Models.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class PaymentController:ControllerBase
{
    private readonly IPaymentService _paymentService;
    public PaymentController(IPaymentService paymentService)
    {
        _paymentService=paymentService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
    {
        var payments=await _paymentService.GetPayments();
        return Ok(payments);
    }

    [HttpGet("{paymentId}")]
    public async Task<ActionResult<Payment>> GetPayment(int paymentId)
    {
        var payment=await _paymentService.GetPayment(paymentId);
        if(payment==null)
        {
            return NotFound();
        }
        return Ok(payment);
    }

    [HttpPost]
    public async Task<ActionResult<Payment>> AddPayment(Payment newPayment)
    {
        var payment=await _paymentService.AddPayment(newPayment);
        if(ModelState.IsValid) return Ok(payment);
        else return BadRequest(ModelState);
    }

    [HttpPut]
    public async Task<ActionResult<Payment>> UpdatePayment(int id ,Payment payment)
    {
        var updatedPayment=await _paymentService.UpdatePayment(id,payment);
        if(ModelState.IsValid) return Ok(updatedPayment);
        else return BadRequest(ModelState);
    }

    [HttpDelete("{paymentId}")]
    public async Task<ActionResult<Payment>> DeletePayment(int paymentId)
    {
        var payment=await _paymentService.DeletePayment(paymentId);
        if(payment==null) return NotFound();
        return Ok(payment);
    }
}