using HomeworkNetAsp2;
using HomeworkNetAsp2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworAspNet2Task1.Pages
{
    public class AddModel : PageModel
    {
		private AppDbContext _context;
		[BindProperty]
		public Dog Dog { get; set; } = new();
		[BindProperty]
		public Cat Cat { get; set; } = new();
		[BindProperty]
		public Mouse Mouse { get; set; } = new();
		[BindProperty]
		public Spider Spider { get; set; } = new();
		[BindProperty]
		public int Type { get; set; }

		public AddModel(AppDbContext context)
		{
			_context = context;
		}

		public IActionResult OnPost()
        {
			switch (Type)
			{
				case 1:
					Dog.AnimalType = 2;
					_context.Animals.Add(Dog);
					break;
				case 2:
					Cat.AnimalType = 3;
					_context.Animals.Add(Cat);
					break;
				case 3:
					Mouse.AnimalType = 4;
					_context.Animals.Add(Mouse);
					break;
				case 4:
					Spider.AnimalType = 5;
					_context.Animals.Add(Spider);
					break;
			}
			_context.SaveChanges();
			return RedirectToPage("Index");
		}
    }
}
