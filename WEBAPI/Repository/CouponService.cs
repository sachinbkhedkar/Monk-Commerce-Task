using Microsoft.EntityFrameworkCore;
using WEBAPI.Entity;
using WEBAPI.IService;
using WEBAPI.Models;

namespace WEBAPI.Repository
{
    public class CouponService : ICouponService
    {
        TaskContext _context;
        public CouponService(TaskContext _context) { 
            this._context = _context;
        }

        public Models.Coupon CreateCoupon(Models.Coupon coupon)
        {
            // Add coupon to the database
             _context.Coupons.Add(new Entity.Coupon
             {
                 //Type=coupon.Type,

             });
            // _context.SaveChanges();
            return coupon; // Return created coupon
        }

        public IEnumerable<Models.Coupon> GetAllCoupons()
        {
            // Retrieve all coupons from the database
            return _context.Coupons.Select(x=>new Models.Coupon
            {

            }).ToList();
        }

        public Models.Coupon GetCouponById(int id)
        {
            return _context.Coupons.Where(x=>x.Id==id).Select(x => new Models.Coupon
            {

            }).FirstOrDefault();
        }

        public List<Models.Coupon> GetApplicableCoupons(Models.Cart cart)
        {
            // Logic to determine applicable coupons based on cart contents
            // This can include checking thresholds, product IDs, etc.
            return new List<Models.Coupon>();
        }

        public Models.Cart ApplyCoupon(int id, Models.Cart cart)
        {
            // Apply the coupon logic to the cart
            // Update the cart prices based on the coupon
            return cart;
        }

        public string Delete(int id)
        {
            try
            {
                var c = _context.Coupons.FirstOrDefault(x => x.Id == id);
                _context.Coupons.Remove(c);
                _context.SaveChanges();
                return "success";

            }
            catch (Exception ex) {
                return ex.ToString();
            }

        }
    }
}
