using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;

public class PaymentRepository:IPaymentRepository
{
    private readonly AppDbContext _context;
    public PaymentRepository(AppDbContext context)
    {
        _context=context;
    }

    public async Task<Payment> AddPayment(Payment newPayment)
    {
        var payment=await _context.Payments.AddAsync(newPayment);
        await _context.SaveChangesAsync();
        return payment.Entity;
    }

    public async Task<Payment> DeletePayment(int paymentId)
    {
        var payment=await _context.Payments.FindAsync(paymentId);
        if (payment!=null)
        {
            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
        }
        return payment;
    }

    public async Task<Payment> GetPayment(int paymentId)
    {
        var payment=await _context.Payments.FirstOrDefaultAsync(p=>p.PaymentID==paymentId);
        return payment;
    }

    public async Task<IEnumerable<Payment>> GetPayments()
    {
        return await _context.Payments.ToListAsync();
    }

    public async Task<Payment> UpdatePayment(int id,Payment payment)
    {
       var existingPayment=await _context.Payments.FirstOrDefaultAsync(p=>p.PaymentID==id);
       if(existingPayment!=null)
       {
           existingPayment.PaymentID=payment.PaymentID;
           existingPayment.BookingID=payment.BookingID;
           existingPayment.PaymentDate=payment.PaymentDate;
           existingPayment.PaymentStatus=payment.PaymentStatus;
           existingPayment.PaymentMethod=payment.PaymentMethod;
           existingPayment.PaymentAmount=payment.PaymentAmount;
           _context.Payments.Update(existingPayment);
           await _context.SaveChangesAsync();
       }
       return payment;
    }
}