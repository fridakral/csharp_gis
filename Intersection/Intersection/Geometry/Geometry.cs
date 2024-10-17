namespace Intersection.Geometry;

public abstract class Geometry
{
    public List<Coordinate> Coordinates { get; set; }

    public string ToString()
    {
        string coords = "";
        foreach (Coordinate coordinate in Coordinates)
        {
            coords += coordinate.GetCoordinateString();
            coords += ", ";
        }
        return coords.Remove(coords.Length - 2);
    }

    public abstract string CoordinatesToWkt();

}