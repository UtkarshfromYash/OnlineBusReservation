using BlazorProject.Models.Models;

public class BusScheduleService : IBusScheduleService
{
    private readonly IBusScheduleRepository _busScheduleRepository;
    public BusScheduleService(IBusScheduleRepository busScheduleRepository)
    {
        _busScheduleRepository=busScheduleRepository;
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
       return await _busScheduleRepository.GetBusSchedules(busScheduleSearchModel);
    }

    public Task<BusSchedule> UpdateBusSchedule(BusSchedule busSchedule)
    {
        throw new NotImplementedException();
    }
}