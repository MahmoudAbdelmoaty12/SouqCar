using SouqCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Application.Contract
{
    public interface ICategoryRepository:IRepository<Category, int>
    {
        Task<Category> SearchByName(string Name);
        Task DetachEntityAsync(Category entity);
    }
}
