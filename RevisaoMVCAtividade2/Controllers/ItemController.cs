using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RevisaoMVCAtividade2.Data;

namespace RevisaoMVCAtividade2.Controllers;

public class ItemController : Controller
{
    private readonly AppDbContext _context;

    public ItemController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var itens = await _context.Items.ToListAsync();

        return View(itens);
    }
}