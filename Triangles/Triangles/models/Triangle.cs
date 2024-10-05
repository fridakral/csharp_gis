namespace Triangles.models;

public class Triangle
{
    public Coordinate Point1 { get; set; }
    public Coordinate Point2 { get; set; }
    public Coordinate Point3 { get; set; }

    public Triangle(Coordinate point1, Coordinate point2, Coordinate point3)
    {
        Point1 = point1;
        Point2 = point2;
        Point3 = point3;
    }
    
    public void DisplayTriangle(){
        Point1.DisplayInfo();
        Point2.DisplayInfo();
        Point3.DisplayInfo();
    }
}