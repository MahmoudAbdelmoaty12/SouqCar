using SouqCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouqCar.Application.Contract
{
    public interface IOrderDetailsRepository:IRepository<OrderDetail,int>
    {
        Task<List<OrderDetail>>GetOrders(int orderId);
    }
}
