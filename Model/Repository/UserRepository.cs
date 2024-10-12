using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HairSalonBookingApp.Model.Repository.Interfaces;

namespace HairSalonBookingApp.Model.Repository
{
    public class UserRepository
    {
         private readonly List<User> _users = new List<User>
    {
        new User { Id = 1, Username = "admin", Password = "password", Role = "Admin" },
        new User { Id = 2, Username = "customer", Password = "password", Role = "Customer" },
        new User { Id = 3, Username = "stylist", Password = "password", Role = "Stylist" }
    };

    public User ValidateUser(string username, string password)
    {
        return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }

    public void RegisterUser(string username, string password, string role)
    {
        _users.Add(new User { Id = _users.Count + 1, Username = username, Password = password, Role = role });
    }
    }
}