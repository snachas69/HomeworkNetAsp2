using HomeworkAspNet2Task2.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeworkAspNet2Task2
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Shape> Shapes { get; set; }
		public DbSet<Rectangle> Rectangles { get; set; }
		public DbSet<Circle> Circles { get; set; }
		public DbSet<Triangle> Triangles { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
	}
}
