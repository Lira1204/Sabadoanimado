﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sabadoanimado.Models;
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
    public IList<Student> Students { get; set; }
    public async Task OnGetAsync()
    {

        Students = await _context.Students.ToListAsync();
    }
}