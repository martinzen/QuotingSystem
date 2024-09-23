using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;

namespace AspnetCoreMvcFull.Controllers;

public class SolarQuoteController : Controller
{
  public IActionResult SolarQuote() => View();
}
