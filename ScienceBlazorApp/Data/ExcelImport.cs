using System.Data;
using IronXL;

namespace ScienceBlazorApp.Data;

public static class ExcelImport
{
    public static double ReadLrKrFile(string filepath)
    {
        double sum = 0;
        WorkBook wb = WorkBook.Load(filepath);
        DataSet ds = wb.ToDataSet();//behave complete Excel file as DataSet
        foreach (DataTable dt in ds.Tables)//behave Excel WorkSheet as DataTable. 
        {
            DataRow row;
            for(int i = 1; i < dt.Rows.Count; i++)//corresponding Sheet's Rows
            {
                row = dt.Rows[i];   
                sum += Convert.ToDouble(row[0]);
            }
        }
        return sum;
    }
}

