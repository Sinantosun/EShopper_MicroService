using EShopper.Discount.Entites;
using Microsoft.EntityFrameworkCore;

namespace EShopper.Discount.Context
{
    public class DiscountContext : DbContext
    {
        public DiscountContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Coupon> Coupons {  get; set; } 
    }
}
