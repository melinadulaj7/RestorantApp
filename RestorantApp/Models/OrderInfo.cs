using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantApp.Models
{
    public class OrderInfo
    {
        public int Id { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }

      // public string PaymentMethod { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public User User { get; set; }
        public int UserId { get; set; }
        public decimal TotalAmount
        {
            get
            {
                 return OrderItems?.Sum(item => item.SellingPrice * item.Quantity) ?? 0;
            }
        }
    }
}