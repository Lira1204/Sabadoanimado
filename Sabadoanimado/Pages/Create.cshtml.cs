using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Sabadoanimado.Models;

namespace Sabadoanimado.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public concessionaria concessionaria { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.carros.Add(concessionaria);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}

