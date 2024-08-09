using EShopper.Discount.Dtos;
using EShopper.Discount.Entites;

namespace EShopper.Discount.Services
{
    public interface ICouponService
    {
       Task<List<ResultCouponDto>> GetAllCouponsAsync();
       Task<ResultCouponByIdDto> GetCouponById(int id);
       Task CreateCoupon(CreateCouponDto createCouponDto);
       Task UpdateCoupon(UpdateCouponDto UpdateCouponDto);
       Task DeleteCoupon(int id);
    }
}
