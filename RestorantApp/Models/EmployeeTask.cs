using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Models
{
    public class EmployeeTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
