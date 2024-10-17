namespace Intersection.Geometry;

public class Coordinate
{
    public double X { get; set; }
    public double Y { get; set; }

    public Coordinate(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public string GetCoordinateString()
    {
        return $"{this.X} {this.Y}";
    }
    
}