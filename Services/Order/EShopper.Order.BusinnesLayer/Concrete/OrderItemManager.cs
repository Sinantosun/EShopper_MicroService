using EShopper.Order.BusinnesLayer.Abstract;
using EShopper.Order.DataAccsessLayer.Abstract;
using EShopper.Order.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.BusinnesLayer.Concrete
{
    public class OrderItemManager : GenericManager<OrderItem>, IOrderItemService
    {
        public OrderItemManager(IRepository<OrderItem> repository) : base(repository)
        {
        }
    }
}
