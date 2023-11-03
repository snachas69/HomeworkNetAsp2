using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkAspNet2Task2.Models
{
	[Table("Triangles")]
	public class Triangle : Shape
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
	}
}
