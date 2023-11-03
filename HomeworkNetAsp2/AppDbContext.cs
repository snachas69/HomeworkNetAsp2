using HomeworkNetAsp2.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeworkNetAsp2
{
	public class AppDbContext : DbContext
	{
		public DbSet<Animal> Animals { get; set; } = null!;
		public DbSet<Dog> Dogs { get; set; } = null!;
		public DbSet<Cat> Cats { get; set; } = null!; 
		public DbSet<Mouse> Mice { get; set; } = null!;
		public DbSet<Spider> Spiders { get; set; } = null!;

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}
	}
}
