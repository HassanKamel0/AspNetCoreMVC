using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WoodyBook.Model;

namespace WoodyBooks.DataAccess
{
    public class AppDBcontext : IdentityDbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }  //get or set the category table to database
        public DbSet<CoverType> CoverTypes { get; set; }  //get or set the coverType table to database
        public DbSet<Product> Products { get; set; }  //get or set the Product table to database
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
