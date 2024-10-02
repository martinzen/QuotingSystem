namespace AspnetCoreMvcFull.Models { 

  public class AddQuotePDFViewModel

  {

    public Guid? Id { get; set; }
    public QuoteEntry? NameFirst { get; set; }
    public QuoteEntry? NameLast { get; set; }
    public QuoteEntry? Mobile { get; set; }
    public QuoteEntry? Email { get; set; }
    public QuoteEntry? installationAddress { get; set; }
    public QuoteEntry? postAddress { get; set; }
    public QuoteEntry? companyName { get; set; }
    public QuoteEntry? ABNnumber { get; set; }
    public QuoteEntry? NMI { get; set; }
    public QuoteEntry? meterNumber { get; set; }
    public QuoteEntry? electricityRetailer { get; set; }
    public QuoteEntry? electricityDis { get; set; }
    public QuoteEntry? propertyPhase { get; set; }
    public QuoteEntry? preapprovalNumber { get; set; }
    public QuoteEntry? storyHouse { get; set; }
    public QuoteEntry? roofType { get; set; }
    public QuoteEntry? switchBoardUpgrade { get; set; }

    public StockEntry? companyNamePanels { get; set; }
    public StockEntry? modelPanel { get; set; }
    public StockEntry? panelCapacity { get; set; }
    public StockEntry? numberPanels { get; set; }
    public StockEntry? pricePanel { get; set; }
    public StockEntry? imagePanel { get; set; }
    public StockEntry? companyNameInverter { get; set; }
    public StockEntry? modelInverter { get; set; }
    public StockEntry? inverterCapacity { get; set; }
    public StockEntry? inverterPhase { get; set; }
    public StockEntry? priceInverter { get; set; }
    public StockEntry? numberInverters { get; set; }
    public StockEntry? batteryNameInverter { get; set; }
    public StockEntry? batteryModel { get; set; }
    public StockEntry? batteryCapacity { get; set; }
    public StockEntry? batteryPhase { get; set; }
    public StockEntry? batteryPrice { get; set; }
    public StockEntry? numberBatteries { get; set; }
    public StockEntry? batteryImage { get; set; }


  }


}


