using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models;
using WEBAPI.IService;
namespace WEBAPI.Controllers
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

        [HttpPost]
        public IActionResult CreateCoupon([FromBody] Coupon coupon)
        {
            var createdCoupon = _couponService.CreateCoupon(coupon);
            return CreatedAtAction(nameof(GetCoupon), new { id = createdCoupon.Id }, createdCoupon);
        }

        [HttpGet]
        public IActionResult GetAllCoupons()
        {
            var coupons = _couponService.GetAllCoupons();
            return Ok(coupons);
        }

        [HttpGet("{id}")]
        public IActionResult GetCoupon(int id)
        {
            var coupon = _couponService.GetCouponById(id);
            if (coupon == null)
            {
                return NotFound();
            }
            return Ok(coupon);
        }

        [HttpPost("applicable-coupons")]
        public IActionResult GetApplicableCoupons([FromBody] ApplyCoupen applyCoupen)
        {
            var applicableCoupons = _couponService.GetApplicableCoupons(new Cart());
            return Ok(applicableCoupons);
        }

        [HttpPost("apply-coupon/{id}")]
        public IActionResult ApplyCoupon(int id, [FromBody] Cart cart)
        {
            var updatedCart = _couponService.ApplyCoupon(id, cart);
            return Ok(updatedCart);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_couponService.Delete(id));
        }
    }

}
