using HomeworkAspNet2Task2.Models;

namespace HomeworkAspNet2Task2.Services
{
	public class ShapeService
	{
		internal List<Shape> GetShapes(ApplicationDbContext context, string? shapeName, int shapeTypeSelect)
		{
			switch (shapeTypeSelect)
			{
				case 2:
					return context.Rectangles.Where(i => i.Name.Contains(shapeName ?? "")).ToList<Shape>();
				case 3:
					return context.Triangles.Where(i => i.Name.Contains(shapeName ?? "")).ToList<Shape>();
				case 4:
					return context.Circles.Where(i => i.Name.Contains(shapeName ?? "")).ToList<Shape>();
				default:
					return context.Shapes.Where(i => i.Name.Contains(shapeName ?? "")).ToList<Shape>();
			}
		}
	}
}
