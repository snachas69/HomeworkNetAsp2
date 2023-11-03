using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkAspNet2Task2.Models
{
	[Table("Rectangles")]
	public class Rectangle : Shape
	{
		public int X { get; set; }
		public int Y { get; set; }
	}
}
