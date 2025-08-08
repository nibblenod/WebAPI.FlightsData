using Microsoft.AspNetCore.Mvc;
using WebAPI.FlightsData.Models;
using WebAPI.FlightsData.Services;

namespace WebAPI.FlightsData.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FlightsController : ControllerBase
{
    private readonly IFlightService _flightService;
    public FlightsController(IFlightService flightService)
    {
        _flightService = flightService;
    }
    
   
}