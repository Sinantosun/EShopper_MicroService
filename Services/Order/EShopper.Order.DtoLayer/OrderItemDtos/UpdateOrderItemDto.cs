using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.DtoLayer.OrderItemDtos
{
    public class UpdateOrderItemDto
    {
        public int OrderItemId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get => Quantity * Price; }

        public int OrderingId { get; set; }
    }
}
