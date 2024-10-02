using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using Microsoft.EntityFrameworkCore;
using Solar1.Data;

namespace AspnetCoreMvcFull.Controllers;

public class StockEntryController : Controller
{
  private readonly ApplicationDbContext _context;

  public StockEntryController(ApplicationDbContext _context)
  {
    this._context = _context;
  }


  [HttpGet]
  public IActionResult Stock() => View();

  [HttpPost]
  public async Task<IActionResult> Stock(AddStockEntryViewModel viewModel)
  {
    var entity = new StockEntry
    {

      companyNamePanels = viewModel.companyNamePanels,
      modelPanel = viewModel.modelPanel,
      panelCapacity = viewModel.panelCapacity,
      numberPanels = viewModel.numberPanels,
      pricePanel = viewModel.pricePanel,
      imagePanel = viewModel.imagePanel,
      companyNameInverter = viewModel.companyNameInverter,
      modelInverter = viewModel.modelInverter,
      inverterCapacity = viewModel.inverterCapacity,
      inverterPhase = viewModel.inverterPhase,
      priceInverter = viewModel.priceInverter,
      numberInverters = viewModel.numberInverters,
      batteryNameInverter = viewModel.batteryNameInverter,
      batteryModel = viewModel.batteryModel,
      batteryCapacity = viewModel.batteryCapacity,
      batteryPhase = viewModel.batteryPhase,
      batteryPrice = viewModel.batteryPrice,
      numberBatteries = viewModel.numberBatteries,
      batteryImage = viewModel.batteryImage,
      
    };

    await _context.StockEntries.AddAsync(entity);
    await _context.SaveChangesAsync();

    return View();
  }



}
