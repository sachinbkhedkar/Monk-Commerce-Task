using WEBAPI.Models;

namespace WEBAPI.IService
{
    public interface ICouponService
    {
        Coupon CreateCoupon(Coupon coupon);
        IEnumerable<Coupon> GetAllCoupons();
        Coupon GetCouponById(int id);
        List<Coupon> GetApplicableCoupons(Cart cart);
        Cart ApplyCoupon(int id, Cart cart);
        string Delete(int id);

    }
}
