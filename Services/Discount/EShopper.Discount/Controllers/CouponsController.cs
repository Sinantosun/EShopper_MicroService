using EShopper.Discount.Dtos;
using EShopper.Discount.Services;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly ICouponService _couponService;

        public CouponsController(ICouponService couponService)
        {
            _couponService = couponService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCoupons()
        {
            var values = await _couponService.GetAllCouponsAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCouponById(int id)
        {
            var value = await _couponService.GetCouponById(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CreateCouponDto createCouponDto)
        {
            await _couponService.CreateCoupon(createCouponDto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCoupon(UpdateCouponDto updateCouponDto)
        {

            await _couponService.UpdateCoupon(updateCouponDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCoupon(int id)
        {
            await _couponService.DeleteCoupon(id);
            return Ok();
        }
    }
}
