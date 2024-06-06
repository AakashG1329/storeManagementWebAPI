using Microsoft.EntityFrameworkCore;

namespace StoreManagement.Models
{
    public class StoreDbContext :DbContext
    {
        public StoreDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Carousel> carousel { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Category> categorys { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Wishlist> wishlists { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(x => x.role).WithMany(x => x.user).HasForeignKey(x => x.role_id);
            modelBuilder.Entity<Cart>().HasOne(x => x.cartUser).WithMany(x => x.cart).HasForeignKey(x => x.user_id);
            modelBuilder.Entity<Cart>().HasOne(x => x.cartProduct).WithMany(x => x.cart).HasForeignKey(x => x.product_id);
            modelBuilder.Entity<Order>().HasOne(x => x.orderUser).WithMany(x => x.order).HasForeignKey(x => x.user_id);
            modelBuilder.Entity<Order>().HasOne(x => x.orderProduct).WithMany(x => x.order).HasForeignKey(x => x.product_id);
            modelBuilder.Entity<Product>().HasOne(x => x.seller).WithMany(x => x.product).HasForeignKey(x => x.seller_id);
            modelBuilder.Entity<Product>().HasOne(x => x.category).WithMany(x => x.product).HasForeignKey(x => x.category_id);
            modelBuilder.Entity<Wishlist>().HasOne(x => x.wishlistUser).WithMany(x => x.wishlist).HasForeignKey(x => x.user_id);
            modelBuilder.Entity<Wishlist>().HasOne(x => x.wishlistProduct).WithMany(x => x.wishlist).HasForeignKey(x => x.product_id);
        }
    }
}
