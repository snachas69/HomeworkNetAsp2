using HomeworAspNet2Task1.Services;
using HomeworkNetAsp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkNetAsp2.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private AppDbContext _context;
		private AnimalService _animalService;

		[BindProperty]
		public List<Animal> Animals { get; set; } = new();

		public IndexModel(ILogger<IndexModel> logger, AppDbContext context, AnimalService animalService)
		{
			_logger = logger;
			_context = context;
			_animalService = animalService;
		}

		public void OnGet(string? animalName, int animalTypeSelect)
		{
			//IQueryable<Animal> animals = _context.Animals;

			//if (!string.IsNullOrEmpty(animalName))
			//{
			//	animalName = animalName.ToLower();
			//	animals = animals.Where(s => s.Name.Contains(animalName));
			//}

			//if (AnimalTypeSelect.HasValue && AnimalTypeSelect != 1)
			//{
			//	animals = animals.Where(s => s.AnimalType == AnimalTypeSelect);
			//}

			//Animals = animals.ToList();
			Animals = _animalService.GetAnimal(_context, animalName, animalTypeSelect);
		}
	}
}