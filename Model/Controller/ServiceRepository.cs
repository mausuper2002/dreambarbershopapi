using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HairSalonBookingApp.Model.Repository.Interfaces;

namespace HairSalonBookingApp.Model.Controller
{
    [Route("[controller]")]
    public class ServiceRepository : IServiceRepository
    {
        private readonly List<Service> _services = new List<Service>
    {
        new Service { Id = 1, Name = "Hair Cut", Description = "Basic hair cut", Price = 20, Duration = 30 },
        new Service { Id = 2, Name = "Hair Coloring", Description = "Hair coloring service", Price = 50, Duration = 60 }
    };

        public IEnumerable<Service> GetAllServices()
        {
            return _services;
        }

        public Service GetServiceById(int id)
        {
            return _services.FirstOrDefault(s => s.Id == id);
        }

        public void AddService(Service service)
        {
            _services.Add(service);
        }

        public void DeleteService(int id)
        {
            var service = _services.FirstOrDefault(s => s.Id == id);
            if (service != null)
            {
                _services.Remove(service);
            }
        }
    }
}