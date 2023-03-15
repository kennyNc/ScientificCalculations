using ScientificCalculations.Library;

namespace ScienceBlazorApp.Data;

public class DTOCalculations : IDataTrasferObject
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }

    public DTOCalculations() { }
    public DTOCalculations(double height, double width)
    {
        Height = height;
        Width = width;
        Length = Length;
    }
}
