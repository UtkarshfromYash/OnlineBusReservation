using BlazorProject.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
[ApiController]
[Route("api/[controller]")]
public class BusController:ControllerBase
{
    private readonly IBusService _busService;
    public BusController(IBusService busService)
    {
        _busService=busService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bus>>> GetBuses()
    {
        var buses=await _busService.GetBuses();
        return Ok(buses);
    }

    [HttpGet("{busId}")]
    public async Task<ActionResult<Bus>> GetBus(int busId)
    {
        var bus=await _busService.GetBus(busId);
        if(bus==null)
        {
            return NotFound();
        }
        return Ok(bus);
    }
    
    [HttpPost]
    public async Task<ActionResult<Bus>> AddBus(Bus newBus){
        var bus=await _busService.AddBus(newBus);
        if(ModelState.IsValid) return Ok(bus);
        else return BadRequest(ModelState);
    }

    [HttpPut]
    public async Task<ActionResult<Bus>> UpdateBus(Bus bus){
        var updatedBus=await _busService.UpdateBus(bus);
        if(ModelState.IsValid) return Ok(updatedBus);
        else return BadRequest(ModelState);
    }

    [HttpDelete("{busId}")]
    public async Task<ActionResult<Bus>> DeleteBus(int busId){
        var bus=await _busService.DeleteBus(busId);
        if(bus==null) return NotFound();
        return Ok(bus);
    }

}