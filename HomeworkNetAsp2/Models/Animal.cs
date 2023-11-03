namespace HomeworkNetAsp2.Models
{
	public abstract class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Spicies { get; set; } = null!;
		public int Age { get; set; }
		public string Sound { get; set; } = null!;
		public int AnimalType { get; set; }
	}
}
