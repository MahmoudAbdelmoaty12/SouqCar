
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Models
{
    public class SouqCarUser: IdentityUser
    {
       public string? UserName { get; set; }
        public string? Address { get; set; }
        public string? Img { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<Order> Orders { get; set; }
        public ICollection<Product> products { get; set; }






    }
}
