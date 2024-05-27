using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Models
{
    public class Specification : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<CategorySpecifications>? CategorySpecifications { get; set; }
        public ICollection<ProductCategorySpecifications>? ProductSpecification { get; set; }



        public Specification()
        {
            CategorySpecifications = new List<CategorySpecifications>();
            ProductSpecification = new List<ProductCategorySpecifications>();
        }
    }
}
