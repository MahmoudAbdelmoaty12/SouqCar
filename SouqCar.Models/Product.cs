using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Models
{
    public class Product:BaseEntity
    {
      
        public int ModelYear { get; set; } // 2024
        public string Make { get; set; } // سكودا
        public string Model { get; set; } // كودياك
        public int Mileage { get; set; } // 0
        public string Condition { get; set; } // جديد
        public string Transmission { get; set; } // أوتوماتيك
        public string FuelType { get; set; } // بنزين
        public string EngineCapacity { get; set; } // 1400-1599 CC
        public string BodyType { get; set; } // SUV
        public string PaymentMethod { get; set; } // تقسيط
        public string Color { get; set; }
        public int Quantity { get; set; }
        public decimal Pricce { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime? DateAdded { get; set; } = DateTime.Now;
        public ICollection<Image>? Images { get; set; }
        public string UserId { get; set; }
        public SouqCarUser User { get; set; }
        public ICollection<ProductCategorySpecifications>? ProductCategorySpecifications { get; set; }

        public Product()
        {
            ProductCategorySpecifications = new List<ProductCategorySpecifications>();
            OrderDetails = new List<OrderDetail>();
            Images = new List<Image>();
        }
    }

}
