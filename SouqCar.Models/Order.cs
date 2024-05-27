using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Models
{

    public class Order:BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Phone { get; set; }
        public decimal? TotalPrice { get; set; }
        public SouqCarUser User { get; set; }
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        public DateTime? DeliveryDate { get; set; } = DateTime.Now.AddDays(3);
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
      
    }
}
