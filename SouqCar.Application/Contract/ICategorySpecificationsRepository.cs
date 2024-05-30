using SouqCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Application.Contract
{
    public interface ICategorySpecificationsRepository: IRepository<CategorySpecifications,int>
    { 
        Task<CategorySpecifications> GetCategorySpecificationsAsync(int CategoryId,int specificationId );
    }
}
