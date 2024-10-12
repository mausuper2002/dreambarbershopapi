using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HairSalonBookingApp.Model.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace HairSalonBookingApp.Model.Controller
{
    [Route("[controller]")]
// Controllers/ServiceController.cs
[ApiController]
[Route("api/[controller]")]
public class ServiceController : ControllerBase
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceController(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    [HttpGet]
    public IActionResult GetServices()
    {
        var services = _serviceRepository.GetAllServices();
        return Ok(services);
    }

    [HttpPost]
    [Authorize(Roles = "Manager")]
    public IActionResult AddService([FromBody] Service service)
    {
        _serviceRepository.AddService(service);
        return Ok();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Manager")]
    public IActionResult DeleteService(int id)
    {
        _serviceRepository.DeleteService(id);
        return Ok();
    }
}

}