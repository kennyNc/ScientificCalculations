using IronXL;
using System.IO.Enumeration;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace ScienceBlazorApp.Data;

public class ExcelDataService
{
    readonly List<string> pm = new List<string>();
    readonly List<string> pb = new List<string>();
    readonly List<string> qm = new List<string>();
    readonly List<string> qb = new List<string>();

    void FetchData(string path)
    {
        WorkBook workbook = WorkBook.Load(path);
        WorkSheet sheet = workbook.WorkSheets.First();

        int rowcount = sheet.Rows.Count();
        string address = string.Format("A2:A{0}", rowcount);
        foreach (var cell in sheet[address])
        {
            pm.Add(cell.Text);
        }
    }
    public Task<ExcelData[]> GetExcelAsync(string path)
    {
        WorkBook workbook = WorkBook.Load(path);
        WorkSheet sheet = workbook.WorkSheets.First();

        int rowcount = sheet.RowCount; //  sheet.Rows.Count();
        // System.Diagnostics.Debug.WriteLine("rowcount: {0}", rowcount);
        string address = string.Format("A2:A{0}", rowcount);
        foreach (var cell in sheet[address])
        {
            pm.Add(cell.Text);
        }
        return Task.FromResult(Enumerable.Range(0, 100).Select(index => new ExcelData
        {
            Pm = pm[index],            
        }).ToArray());
    }
}
