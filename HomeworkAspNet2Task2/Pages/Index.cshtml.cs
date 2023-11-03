using HomeworkAspNet2Task2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkAspNet2Task2.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private ApplicationDbContext _context;

		[BindProperty] 
		public List<Shape> Shapes { get; set; } = new();

		[BindProperty(SupportsGet = true)] 
		public int? ShapeTypeSelect { get; set; }

		public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		public void OnGet(string? shapeName)
		{
			IQueryable<Shape> shapes = _context.Shapes;

			if (!string.IsNullOrEmpty(shapeName))
			{
				shapeName = shapeName.ToLower();
				shapes = shapes.Where(s => s.Name.Contains(shapeName));
			}

			if (ShapeTypeSelect.HasValue && ShapeTypeSelect != 1)
			{
				shapes = shapes.Where(s => s.ShapeType == ShapeTypeSelect);
			}

			Shapes = shapes.ToList();
		}
	}
}