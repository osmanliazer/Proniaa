using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DataAccesLayer
{
    public class ProniaContext : DbContext
    {
        public ProniaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=sql8010.site4now.net;Database=db_aa860b_azer;User Id=db_aa860b_azer_admin;Password=whcy1583;");
            base.OnConfiguring(options);
        }
    }
}
