namespace ScientificCalculations.Library;
public class Calculations
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Calculations(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double DoCalculationsForSingleSet()
    {
        // Read data from Reference TableA1 //
        return new double();
    }
    public double GetVolume()
    {
        return Length * Width * Height;
    }
    public double[] DoCalcuationsfForRange(double[,] widthRange)
    {
        // Do some complex calculations involving iterations, etc.
        // This calculations involves reading TableA1 over each iteration.
        return new double[1000];
    }
}
