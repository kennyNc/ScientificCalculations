using ScientificCalculations.Library;

namespace ScientificCalculations;

public static class SciCalcGateway
{
    public static double ComplicatedCalculations(IDataTrasferObject dto)
    {
        double a = dto.Length;
        double b = dto.Width;
        double c = dto.Height;

        Calculations newCalc = new Calculations(a, b, c);        

        return newCalc.GetVolume();
    }
}