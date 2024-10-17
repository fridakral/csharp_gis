using System.Globalization;

namespace Intersection.Geometry;

public class Polygon : Geometry
{
    public static Polygon ReadFromWkt(string path)
    {
        var wktLine = FileReader.ReadFile(path);
        if (!wktLine.StartsWith("POLYGON"))
        {
            throw new FormatException();
        }
        else
        {
            //POLYGON ((30 10.1, 40.3 40, 20 40, 10 20, 30 10))
            var stringWktLine = wktLine.Replace("POLYGON ((", "");
            stringWktLine = stringWktLine.Replace("))", "");
            var wktLineParts = stringWktLine.Split(',');
            var coordinates = new List<Coordinate>();
            
            foreach (var part in wktLineParts)
            {
                string[] coordinateParts = part.Trim().Split(' ');
                Coordinate coordinate = new Coordinate(double.Parse(coordinateParts[0], CultureInfo.InvariantCulture.NumberFormat), double.Parse(coordinateParts[1], CultureInfo.InvariantCulture.NumberFormat));
                coordinates.Add(coordinate);
            }
            Polygon polygon = new Polygon();
            polygon.Coordinates = coordinates;
            return polygon;
        }
    }
    
    public override string CoordinatesToWkt()
    {
        string wkt = "POLYGON ((";
        wkt += this.ToString();
        wkt += "))";
        return wkt;
    }
}