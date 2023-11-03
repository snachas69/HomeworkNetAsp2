using HomeworkAspNet2Task2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeworkAspNet2Task2.Pages
{
    public class AddModel : PageModel
    {
        private ApplicationDbContext _context;
		[BindProperty]
		public Triangle Triangle { get; set; } = new();
		[BindProperty]
		public Rectangle Rectangle { get; set; } = new();
		[BindProperty]
		public Circle Circle { get; set; } = new();
        [BindProperty]
        public int Type { get; set; }

        public AddModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            switch(Type)
            {
                case 1:
                    Rectangle.ShapeType = 2;
                    _context.Shapes.Add(Rectangle); 
                    break;
				case 2:
                    Triangle.ShapeType = 3;
					_context.Shapes.Add(Triangle);
					break;
				case 3:
                    Circle.ShapeType = 4;
					_context.Shapes.Add(Circle);
					break;
			}
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
