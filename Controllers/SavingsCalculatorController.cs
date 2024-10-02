using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;

namespace AspnetCoreMvcFull.Controllers;

public class SavingsCalculatorController : Controller
{
  public IActionResult SavingsCal() => View();
}
