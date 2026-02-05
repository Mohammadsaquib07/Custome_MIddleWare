using Microsoft.EntityFrameworkCore;

public class PaymentRepository:IPaymentRepository
{
    private readonly AppDbContext _context;
    public PaymentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Payment payment)
    {
        _context.Payments.Add(payment);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Payment>> GetAllAsync()
    {
        return await _context.Payments.ToListAsync();
    }
}