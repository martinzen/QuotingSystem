using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;

namespace AspnetCoreMvcFull.Controllers;

public class InstallationsPerWeekController : Controller
{
  public IActionResult Installations() => View();
}
