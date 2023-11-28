using HomeworkNetAsp2;
using HomeworkNetAsp2.Models;

namespace HomeworAspNet2Task1.Services
{
	public class AnimalService
	{
		internal List<Animal> GetAnimal(AppDbContext context, string? animalName, int animalTypeSelect)
		{
			switch (animalTypeSelect) 
			{
				case 2:
					return context.Dogs.Where(i => i.Name.Contains(animalName ?? "")).ToList<Animal>();
				case 3:
					return context.Cats.Where(i => i.Name.Contains(animalName ?? "")).ToList<Animal>();
				case 4:
					return context.Mice.Where(i => i.Name.Contains(animalName ?? "")).ToList<Animal>();
				case 5:
					return context.Spiders.Where(i => i.Name.Contains(animalName ?? "")).ToList<Animal>();
				default:
					return context.Animals.Where(i => i.Name.Contains(animalName ?? "")).ToList<Animal>();
			}
		}
	}
}
