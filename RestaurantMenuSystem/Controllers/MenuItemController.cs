using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantMenuSystem.Data;

namespace RestaurantMenuSystem.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly RestaurantMenuDbContext _context;

        public MenuItemController(RestaurantMenuDbContext context)
        {
            _context = context;
        }

        // List all + filter by category
        public async Task<IActionResult> Index(string category)
        {
            var categories = await _context.MenuItems
                .Select(m => m.Category)
                .Distinct()
                .ToListAsync();

            ViewBag.Categories = categories;
            ViewBag.SelectedCategory = category;

            var items = string.IsNullOrEmpty(category)
                ? await _context.MenuItems.ToListAsync()
                : await _context.MenuItems
                    .Where(m => m.Category == category)
                    .ToListAsync();

            return View(items);
        }

        // Details page
        public async Task<IActionResult> Details(int id)
        {
            var item = await _context.MenuItems
                .FirstOrDefaultAsync(m => m.Id == id);

            if (item == null)
                return NotFound();

            return View(item);
        }
    }
}