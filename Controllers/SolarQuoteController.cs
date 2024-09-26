using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using Microsoft.EntityFrameworkCore;
using Solar1.Data;

namespace AspnetCoreMvcFull.Controllers;

public class SolarQuoteController : Controller
{
 
  private readonly ApplicationDbContext _context;

  public SolarQuoteController(ApplicationDbContext _context)
  {
    this._context = _context;
  }

  [HttpGet]
  public async Task<IActionResult> SolarQuote()
  {

    var products = await _context.QuoteEntries.ToListAsync();

    return View(products);
  }

}

