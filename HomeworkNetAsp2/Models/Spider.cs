using System.ComponentModel.DataAnnotations.Schema;

namespace HomeworkNetAsp2.Models
{
	[Table("Spiders")]
	public class Spider : Animal
	{
		public bool IsPoisonous { get; set; }
	}
}
