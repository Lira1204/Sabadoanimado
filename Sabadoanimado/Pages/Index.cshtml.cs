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
}
