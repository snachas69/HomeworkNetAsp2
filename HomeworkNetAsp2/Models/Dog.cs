using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkNetAsp2.Models
{
	[Table("Dogs")]
	public class Dog : Animal
	{
		public string TrainedFor { get; set; } = null!;
	}
}
