using HomeworkAspNet2Task2.Models;
using HomeworkAspNet2Task2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkAspNet2Task2.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		private ApplicationDbContext _context;
		private ShapeService _shapeService;

		[BindProperty] 
		public List<Shape> Shapes { get; set; } = new();

		public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context, ShapeService shapeService)
		{
			_logger = logger;
			_context = context;
			_shapeService = shapeService;
		}

		public void OnGet(string? shapeName, int shapeTypeSelect)
		{
			Shapes = _shapeService.GetShapes(_context, shapeName, shapeTypeSelect);
		}
	}
}