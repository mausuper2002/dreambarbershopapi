using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairSalonBookingApp.Model.Repository
{
    public class StylistRepository
    {
        private readonly List<Stylist> _stylists = new List<Stylist>
    {
        new Stylist { Id = 1, Name = "John Doe", Expertise = "Hair Cut" },
        new Stylist { Id = 2, Name = "Jane Smith", Expertise = "Hair Coloring" }
    };

    public IEnumerable<Stylist> GetAllStylists()
    {
        return _stylists;
    }
    }
}