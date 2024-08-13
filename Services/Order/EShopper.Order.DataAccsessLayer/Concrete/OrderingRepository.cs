using EShopper.Order.DataAccsessLayer.Abstract;
using EShopper.Order.DataAccsessLayer.Context;
using EShopper.Order.EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.DataAccsessLayer.Concrete
{
    public class OrderingRepository : Repository<Ordering>, IOrderingRepository
    {
        public OrderingRepository(OrderContext context) : base(context)
        {
        }
    }
}
