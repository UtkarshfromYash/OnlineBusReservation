using BlazorProject.Models.Models;

public class PaymentService:IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;
    public PaymentService(IPaymentRepository paymentRepository)
    {
        _paymentRepository=paymentRepository;
    }

    public async Task<Payment> AddPayment(Payment newPayment)
    {
        return await _paymentRepository.AddPayment(newPayment);
    }

    public async Task<Payment> DeletePayment(int paymentId)
    {
        return await _paymentRepository.DeletePayment(paymentId);
    }

    public async Task<Payment> GetPayment(int paymentId)
    {
        return await _paymentRepository.GetPayment(paymentId);
    }

    public async Task<IEnumerable<Payment>> GetPayments()
    {
        return await _paymentRepository.GetPayments();
    }

    public async Task<Payment> UpdatePayment(int id, Payment payment)
    {
        return await _paymentRepository.UpdatePayment(id,payment);
    }
}