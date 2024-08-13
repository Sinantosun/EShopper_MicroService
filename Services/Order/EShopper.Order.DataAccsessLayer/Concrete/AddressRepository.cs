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
    public class AddressRepository : Repository<Address>, IAddresRepository
    {
        public AddressRepository(OrderContext context) : base(context)
        {
        }
    }
}
