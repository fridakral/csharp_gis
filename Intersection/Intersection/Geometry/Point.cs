using System.Globalization;

namespace Intersection.Geometry;

public class Point : Geometry
{

    public static Point ReadFromWkt(string path)
    {
        var wktLine = FileReader.ReadFile(path);
        if (!wktLine.StartsWith("POINT"))
        {
            throw new FormatException();
        }
        else
        {
            //POINT (30 10)
            var stringWktLine = wktLine.Replace("POINT (", "");
            stringWktLine = stringWktLine.Replace(")", "");
            var coordinates = new List<Coordinate>();

            string[] coordinateParts = stringWktLine.Split(' ');
            Coordinate coordinate =
                new Coordinate(double.Parse(coordinateParts[0], CultureInfo.InvariantCulture.NumberFormat),
                    double.Parse(coordinateParts[1], CultureInfo.InvariantCulture.NumberFormat));
            coordinates.Add(coordinate);
            Point point = new Point();
            point.Coordinates = coordinates;
            return point;
        }
    }
    
    public override string CoordinatesToWkt()
    {
        string wkt = "POINT (";
        wkt += this.ToString();
        wkt += ")";
        return wkt;
    }
}