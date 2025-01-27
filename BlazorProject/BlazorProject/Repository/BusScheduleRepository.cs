using BlazorProject.Components;
using BlazorProject.Models.Models;
using Microsoft.EntityFrameworkCore;

public class BusScheduleRepository : IBusScheduleRepository
{
    private readonly AppDbContext _context;
    public BusScheduleRepository(AppDbContext context)
    {
        _context=context;
    }

    public Task<BusSchedule> AddBusSchedule(BusSchedule busSchedule)
    {
        throw new NotImplementedException();
    }

    public Task<BusSchedule> DeleteBusSchedule(int scheduleId)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<BusScheduleViewModel>> GetBusSchedules(BusScheduleSearchModel busScheduleSearchModel)
    {
        var busSchedule=await _context.BusScheduleViewModels.FromSqlInterpolated($"exec SP_BusSchedules {busScheduleSearchModel.Source},{busScheduleSearchModel.Destination}").ToListAsync();
        return busSchedule;
    }

    public Task<BusSchedule> UpdateBusSchedule(BusSchedule busSchedule)
    {
        throw new NotImplementedException();
    }
}