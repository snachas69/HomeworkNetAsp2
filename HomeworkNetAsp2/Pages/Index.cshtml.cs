using HomeworkNetAsp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkNetAsp2.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private AppDbContext _context;
		[BindProperty]
		public List<Animal> Animals { get; set; } = new();

		[BindProperty(SupportsGet = true)]
		public int? AnimalTypeSelect { get; set; }
		public IndexModel(ILogger<IndexModel> logger, AppDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public void OnGet(string? animalName)
		{
			IQueryable<Animal> animals = _context.Animals;

			if (!string.IsNullOrEmpty(animalName))
			{
				animalName = animalName.ToLower();
				animals = animals.Where(s => s.Name.Contains(animalName));
			}

			if (AnimalTypeSelect.HasValue && AnimalTypeSelect != 1)
			{
				animals = animals.Where(s => s.AnimalType == AnimalTypeSelect);
			}

			Animals = animals.ToList();
		}
	}
}