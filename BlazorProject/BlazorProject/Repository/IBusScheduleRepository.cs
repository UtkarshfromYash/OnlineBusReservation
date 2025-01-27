using BlazorProject.Models.Models;

public interface IBusScheduleRepository
{
    Task<IEnumerable<BusScheduleViewModel>> GetBusSchedules(BusScheduleSearchModel busScheduleSearchModel);

    Task<BusSchedule>AddBusSchedule(BusSchedule busSchedule);
    Task<BusSchedule> UpdateBusSchedule(BusSchedule busSchedule);
    Task<BusSchedule> DeleteBusSchedule(int scheduleId);
}