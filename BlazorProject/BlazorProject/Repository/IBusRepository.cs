using BlazorProject.Models.Models;

public interface IBusRepository
{
    Task<IEnumerable<Bus>> GetBuses();
    Task<Bus> GetBus(int busId);
    Task<Bus> AddBus(Bus bus);
    Task<Bus> UpdateBus(Bus bus);
    Task<Bus> DeleteBus(int busId);

}