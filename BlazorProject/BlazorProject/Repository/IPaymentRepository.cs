using BlazorProject.Models.Models;

public interface IPaymentRepository
{
    Task<IEnumerable<Payment>> GetPayments();
    Task<Payment> GetPayment(int paymentId);
    Task<Payment> AddPayment(Payment newPayment);
    Task<Payment> UpdatePayment(int id,Payment payment);
    Task<Payment> DeletePayment(int paymentId);
}