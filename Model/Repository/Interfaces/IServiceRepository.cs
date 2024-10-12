using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonBookingApp.Model.Repository.Interfaces
{
    public interface IServiceRepository
    {
            IEnumerable<Service> GetAllServices();
    Service GetServiceById(int id);
    void AddService(Service service);
    void DeleteService(int id);
    }
}