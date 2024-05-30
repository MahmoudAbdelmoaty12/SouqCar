using SouqCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Application.Contract
{
    public interface ISouqCarUserRepository:IRepository<SouqCarUser,int>
    {
        Task<SouqCarUser> SearchByName(string Name);
        Task<bool> IsUserNameExists(string UserName);

    }
}
