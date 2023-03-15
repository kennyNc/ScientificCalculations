using IronXL;

namespace CalculationsBlazorApp.Data;
public class ExcelDataService
{
    readonly List<string> sMode = new List<string>();
    readonly List<string> pAmount = new List<string>();
    readonly List<string> uPrice = new List<string>();
    readonly List<string> sCost = new List<string>();
    readonly List<string> cName = new List<string>();
    private void datafetch(string userGivenPath)
    {
        WorkBook workbook = WorkBook.Load(userGivenPath);
        WorkSheet sheet = workbook.WorkSheets.First();
        foreach (var cell in sheet["A2:A15"])
        {
            sMode.Add(cell.Text);
        }
        foreach (var cell in sheet["B2:B15"])
        {
            pAmount.Add(cell.Text);
        }
        foreach (var cell in sheet["C2:C15"])
        {
            uPrice.Add(cell.Text);
        }
        foreach (var cell in sheet["D2:D15"])
        {
            sCost.Add(cell.Text);
        }
        foreach (var cell in sheet["E2:E15"])
        {
            cName.Add(cell.Text);
        }
    }
    public Task<ExcelData[]> GetExcelAsync(string userGivenPath)
    {
        datafetch(userGivenPath);
        return Task.FromResult(Enumerable.Range(0, 13).Select(index => new ExcelData
        {
            ShipMode = sMode[index],
            Profit = pAmount[index],
            UnitPrice = uPrice[index],
            ShippingCost = sCost[index],
            CustomerName = cName[index]
        }).ToArray());
    }

    
}
