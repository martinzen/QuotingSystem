using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreMvcFull.Models;
using Solar1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace AspnetCoreMvcFull.Controllers;

public class QuoteEntryController : Controller
{
  private readonly ApplicationDbContext _context;

  public QuoteEntryController(ApplicationDbContext _context)
  {
    this._context = _context;
  }
   
  [HttpGet]
  public IActionResult Quote()
  {
    return View();
  }

  [HttpPost]
  public async Task<IActionResult> Quote(AddQuoteEntryViewModel viewModel)
  {
    var entity = new QuoteEntry
    {
      
      NameFirst = viewModel.NameFirst,
      NameLast = viewModel.NameLast,
      Mobile = viewModel.Mobile,
      installationAddress = viewModel.installationAddress,
      postAddress = viewModel.postAddress,
      Email = viewModel.Email,
      ABNnumber = viewModel.ABNnumber,
      companyName = viewModel.companyName,
      electricityDis = viewModel.electricityDis,
      electricityRetailer = viewModel.electricityRetailer,
      meterNumber = viewModel.meterNumber,
      NMI = viewModel.NMI,
      preapprovalNumber = viewModel.preapprovalNumber,
      propertyPhase = viewModel.propertyPhase,
      roofType = viewModel.roofType,
      storyHouse = viewModel.storyHouse,
      switchBoardUpgrade = viewModel.switchBoardUpgrade,

    };

    await _context.QuoteEntries.AddAsync(entity);
    await _context.SaveChangesAsync();

    return View();
  }

  [HttpGet]
  public async Task<IActionResult> QuotePDF(Guid id)
  {
    var QuoteEntity = await _context.QuoteEntries.FindAsync(id);

    return View(QuoteEntity);
  }

  [HttpGet]
  public async Task<IActionResult> Edit(Guid id)
  {
    var QuoteEntity = await _context.QuoteEntries.FindAsync(id);

    return View(QuoteEntity);
  }

  [HttpPost]
  public async Task<IActionResult> Edit(QuoteEntry viewModel)
  {
    var QuoteEntity = await _context.QuoteEntries.FindAsync(viewModel.Id);

    if (QuoteEntity is not null)
    {
      QuoteEntity.NameFirst = viewModel.NameFirst;
      QuoteEntity.NameLast = viewModel.NameLast;
      QuoteEntity.Mobile = viewModel.Mobile;
      QuoteEntity.installationAddress = viewModel.installationAddress;
      QuoteEntity.postAddress = viewModel.postAddress;
      QuoteEntity.Email = viewModel.Email;
      QuoteEntity.ABNnumber = viewModel.ABNnumber;
      QuoteEntity.companyName = viewModel.companyName;
      QuoteEntity.electricityDis = viewModel.electricityDis;
      QuoteEntity.electricityRetailer = viewModel.electricityRetailer;
      QuoteEntity.meterNumber = viewModel.meterNumber;
      QuoteEntity.NMI = viewModel.NMI;
      QuoteEntity.preapprovalNumber = viewModel.preapprovalNumber;
      QuoteEntity.propertyPhase = viewModel.propertyPhase;
      QuoteEntity.roofType = viewModel.roofType;
      QuoteEntity.storyHouse = viewModel.storyHouse;
      QuoteEntity.switchBoardUpgrade = viewModel.switchBoardUpgrade;

      await _context.SaveChangesAsync();

    }


    return RedirectToAction("SolarQuote", "SolarQuote");

  }


}
