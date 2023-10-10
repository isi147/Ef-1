using ConsoleApp25.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp25.Context
{
	public class ShopDbContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopApp;Integrated Security=True;Connect Timeout=30;Encrypt=False");
			base.OnConfiguring(optionsBuilder);

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppUser>().Ignore("RePassword");
			//modelBuilder.Entity<AppUser>().HasKey("UserName");
			base.OnModelCreating(modelBuilder);
		}


		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserDetails> AppUserDetails { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Order> Orders { get; set; }

	}
}
