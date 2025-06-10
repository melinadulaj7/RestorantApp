using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RestorantApp.Models;
using RestorantApp;
namespace RestorantApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public ICollection<OrderInfo> Orders { get; set; } = new List<OrderInfo>();
        public User() { }

        public User(string username, string passwordHash, string role)
        {
            Username = username;
            PasswordHash = passwordHash;
            Role = role;
        }

        public override string ToString()
        {
            return $"{Username} ({Role})";
        }
    }
}
