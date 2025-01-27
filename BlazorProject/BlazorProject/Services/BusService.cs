using BlazorProject.Models.Models;
public class BusService:IBusService
{
    private readonly IBusRepository _busRepository;
    public BusService(IBusRepository busRepository)
    {
        _busRepository=busRepository;
    }
    public async Task<Bus> AddBus(Bus bus)
    {
        return await _busRepository.AddBus(bus);
    }
    public async Task<Bus> GetBus(int busId)
    {
        return await _busRepository.GetBus(busId);
    }
    public async Task<IEnumerable<Bus>> GetBuses()
    {
        return await _busRepository.GetBuses();
    }
    public async Task<Bus> UpdateBus(Bus bus)
    {
        return await _busRepository.UpdateBus(bus);
    }
    public async Task<Bus> DeleteBus(int busId)
    {
        return await _busRepository.DeleteBus(busId);
    }
}