namespace HomeworkAspNet2Task2.Models
{
	public abstract class Shape
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int ShapeType { get; set; }
	}
}
