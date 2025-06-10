using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Models
{
  public class Reservation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime ReservationDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}
