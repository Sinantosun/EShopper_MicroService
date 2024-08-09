using EShopper.Discount.Context;
using EShopper.Discount.Dtos;
using EShopper.Discount.Entites;
using Microsoft.EntityFrameworkCore;

namespace EShopper.Discount.Services
{
    public class CouponService : ICouponService
    {
        private readonly DiscountContext _discountContext;

        public CouponService(DiscountContext discountContext)
        {
            _discountContext = discountContext;
        }

        public async Task CreateCoupon(CreateCouponDto createCouponDto)
        {
            _discountContext.Coupons.Add(new Coupon
            {
                DiscountCode = createCouponDto.DiscountCode,
                DiscountRate = createCouponDto.DiscountRate,
                ExpiresIn = createCouponDto.ExpiresIn,
                IsActive = createCouponDto.IsActive,

            });
            await _discountContext.SaveChangesAsync();
        }

        public async Task DeleteCoupon(int id)
        {
            var value = await _discountContext.Coupons.FindAsync(id);
            _discountContext.Coupons.Remove(value);
            await _discountContext.SaveChangesAsync();
        }

        public async Task<List<ResultCouponDto>> GetAllCouponsAsync()
        {
            var values = await _discountContext.Coupons.ToListAsync();
            return values.Select(x => new ResultCouponDto
            {
                CouponId = x.CouponId,
                DiscountCode = x.DiscountCode,
                DiscountRate = x.DiscountRate,
                ExpiresIn = x.ExpiresIn,
                IsActive = x.IsActive,

            }).ToList();
        }

        public async Task<ResultCouponByIdDto> GetCouponById(int id)
        {
            var value = await _discountContext.Coupons.FindAsync(id);
            return new ResultCouponByIdDto
            {
                CouponId = value.CouponId,
                DiscountCode = value.DiscountCode,
                DiscountRate = value.DiscountRate,
                ExpiresIn = value.ExpiresIn,
                IsActive = value.IsActive,
            };
        }

        public async Task UpdateCoupon(UpdateCouponDto UpdateCouponDto)
        {
            var value = await _discountContext.Coupons.FindAsync(UpdateCouponDto.CouponId);
            value.DiscountRate = UpdateCouponDto.DiscountRate;  
            value.ExpiresIn = UpdateCouponDto.ExpiresIn;    
            value.DiscountCode=UpdateCouponDto.DiscountCode;    
            value.IsActive = UpdateCouponDto.IsActive;  
            _discountContext.Coupons.Update(value);
            await _discountContext.SaveChangesAsync();
        }
    }
}
