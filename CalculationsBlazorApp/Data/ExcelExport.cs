using IronXL;
using Microsoft.JSInterop;
using System;

namespace CalculationsBlazorApp.Data;

public class ExcelExport
{
    public void ExcelGenerate(IJSRuntime iJSRuntime)
    {
        byte[] fileContents;
        WorkBook xlsxWorkbook = WorkBook.Create(IronXL.ExcelFileFormat.XLSX);
        xlsxWorkbook.Metadata.Author = "IronXL";
        //Add a blank WorkSheet
        WorkSheet xlsxSheet = xlsxWorkbook.CreateWorkSheet("new_sheet");
        //Add data and styles to the new worksheet
        xlsxSheet["A1"].Value = "Product EN";
        xlsxSheet["B1"].Value = "SKU";
        xlsxSheet["C1"].Value = "Customer";
        xlsxSheet["A1:C1"].Style.Font.Bold = true;
        xlsxSheet["A2"].Value = "Iron Rods";
        xlsxSheet["A3"].Value = "Mobile Phones";
        xlsxSheet["A4"].Value = "Chargers";
        xlsxSheet["B2"].Value = "105";
        xlsxSheet["B3"].Value = "285";
        xlsxSheet["B4"].Value = "301";
        xlsxSheet["C2"].Value = "Adam";
        xlsxSheet["C3"].Value = "Ellen";
        xlsxSheet["C4"].Value = "Tom";
        fileContents = xlsxWorkbook.ToByteArray();
        iJSRuntime.InvokeAsync<ExcelExport>(
            "saveAsFile",
            "GeneratedExcel.xlsx",
            Convert.ToBase64String(fileContents)
        );
    }
}