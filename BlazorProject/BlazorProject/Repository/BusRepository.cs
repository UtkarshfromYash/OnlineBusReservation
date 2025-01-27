using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;

public class BusRepository:IBusRepository
{
    private readonly AppDbContext _context;
    public BusRepository(AppDbContext context)
    {
        _context=context;
    }

    public async Task<Bus> AddBus(Bus bus)
    {
        await _context.Buses.AddAsync(bus);
        await _context.SaveChangesAsync();
        return bus;
    }
    public async Task<Bus> GetBus(int busId){
        var bus = await _context.Buses.FindAsync(busId);
        return bus;
    }

    public async Task<IEnumerable<Bus>> GetBuses()
    {
        var buses= await _context.Buses.ToListAsync();
        return buses;
    }

    public async Task<Bus> UpdateBus(Bus bus)
    {
        _context.Buses.Update(bus);
        await _context.SaveChangesAsync();
        return bus;
    }

    public async Task<Bus> DeleteBus(int busId)
    {
        var bus = await _context.Buses.FindAsync(busId);
        if(bus!=null){
            _context.Buses.Remove(bus);
            await _context.SaveChangesAsync();
        }
        return bus;
    }


}