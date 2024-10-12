using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HairSalonBookingApp.Model.Controller
{
    [Route("[controller]")]
    // Controllers/AppointmentController.cs
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();

        [HttpPost]
        [Authorize(Roles = "Customer")]
        public IActionResult BookAppointment([FromBody] Appointment appointment)
        {
            _appointments.Add(appointment);
            return Ok();
        }

        [HttpGet]
        [Authorize(Roles = "Staff, Manager")]
        public IActionResult GetAppointments()
        {
            return Ok(_appointments);
        }
    }

    public class Appointment
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int StylistId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

}