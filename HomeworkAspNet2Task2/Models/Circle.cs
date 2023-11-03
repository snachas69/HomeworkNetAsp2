using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkAspNet2Task2.Models
{
	[Table("Circles")]
	public class Circle : Shape
	{
		public int Radius { get; set; }
	}
}
