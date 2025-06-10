using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestorantApp.Models
{
   public  class ClientFeedback
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
