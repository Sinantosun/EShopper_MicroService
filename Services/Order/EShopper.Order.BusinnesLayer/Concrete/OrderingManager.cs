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
    public class OrderingManager : GenericManager<Ordering>, IOrderingService
    {
        public OrderingManager(IRepository<Ordering> repository) : base(repository)
        {
        }
    }
}
