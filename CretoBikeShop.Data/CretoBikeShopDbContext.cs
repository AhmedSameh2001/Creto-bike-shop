using CretoBikeShop.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CretoBikeShop.Data
{
    public class CretoBikeShopDbContext : IdentityDbContext<User>
    {
        public CretoBikeShopDbContext(DbContextOptions<CretoBikeShopDbContext> options)
            : base(options)
        {
        }
		public DbSet<Cart> carts { get; set; }
        public DbSet<Order> orders { get; set; }
		public DbSet<Category> categories { get; set; }
		public DbSet<CommentEvaluation> commentEvaluations { get; set; }
		public DbSet<Feedback> feedbacks { get; set; }
		public DbSet<News> news { get; set; }
		public DbSet<OrderProduct> orderProducts { get; set; }
		public DbSet<Product> products { get; set; }
		public DbSet<Slider> sliders { get; set; }
		public DbSet<ProductImage> productImages { get; set; }
		public DbSet<User> users { get; set; }
		
	}
}