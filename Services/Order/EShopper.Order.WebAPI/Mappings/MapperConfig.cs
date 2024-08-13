using AutoMapper;
using EShopper.Order.DtoLayer.AddressDtos;
using EShopper.Order.DtoLayer.OrderingDtos;
using EShopper.Order.DtoLayer.OrderItemDtos;
using EShopper.Order.EntityLayer.Entites;

namespace EShopper.Order.WebAPI.Mappings
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<Address, ResultAddressDto>().ReverseMap();
            CreateMap<Address, UpdateAddressDto>().ReverseMap();

            CreateMap<OrderItem, CreateOrderItem>().ReverseMap();
            CreateMap<OrderItem, ResultOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, UpdateOrderItemDto>().ReverseMap();

            CreateMap<Ordering, CreateOrderingDto>().ReverseMap();
            CreateMap<Ordering, ResultOrderingDto>().ReverseMap();
            CreateMap<Ordering, UpdateOrderingDto>().ReverseMap();
        }
    }
}
