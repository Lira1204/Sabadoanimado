
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sabadoanimado.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<concessionaria> carros { get; set; }
    public async Task OnGetAsync()
    {
        carros = await _context.carros.ToListAsync();
    }

    public async Task<IActionResult> OnPostAddAsync(concessionaria newconcessionaria)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        _context.carros.Add(newconcessionaria);
        await _context.SaveChangesAsync();
        return RedirectToPage();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        var concessionaria = await _context.carros.FindAsync(id);
        if (concessionaria != null)
        {
            _context.carros.Remove(concessionaria);
            await _context.SaveChangesAsync();
        }
        return RedirectToPage();
    }
}
