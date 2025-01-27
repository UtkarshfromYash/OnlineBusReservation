using BlazorProject.Models.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BusScheduleController:ControllerBase
{
    private readonly IBusScheduleService _busScheduleService;
    public BusScheduleController(IBusScheduleService busScheduleService)
    {
        _busScheduleService=busScheduleService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BusScheduleViewModel>>> GetBusSchedules([FromQuery] BusScheduleSearchModel busScheduleSearchModel)
    {
        var busSchedules=await _busScheduleService.GetBusSchedules(busScheduleSearchModel);
        return Ok(busSchedules);
    }
}