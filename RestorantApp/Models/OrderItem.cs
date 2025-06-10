using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestorantApp.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        // Fusha që lidh OrderItem me OrderInfo (porosi)
        public int OrderInfoId { get; set; }

        [ForeignKey("OrderInfoId")]
        public virtual OrderInfo Order { get; set; }

        // Emri i produktit (p.sh. "Pizza Margherita")
        public string ProductName { get; set; }

        public int Quantity { get; set; }

        // Nëse ke lidhje me MenuItem (p.sh. produktet e menusë)
        public int MenuItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }

        public decimal CostPrice { get; set; }

        public decimal SellingPrice { get; set; }
    }
}