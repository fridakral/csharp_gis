using System.Globalization;

namespace Intersection.Geometry;

public class Line: Geometry
{
    public static Line ReadFromWkt(string path)
    {
        var wktLine = FileReader.ReadFile(path);
        if (!wktLine.StartsWith("LINESTRING"))
        {
            throw new FormatException();
        }
        else
        {
            //LINESTRING (30 10.1, 40.3 40, 20 40, 10 20, 30 10)
            var stringWktLine = wktLine.Replace("LINESTRING (", "");
            stringWktLine = stringWktLine.Replace(")", "");
            var wktLineParts = stringWktLine.Split(',');
            var coordinates = new List<Coordinate>();
            
            foreach (var part in wktLineParts)
            {
                string[] coordinateParts = part.Trim().Split(' ');
                Coordinate coordinate = new Coordinate(double.Parse(coordinateParts[0], CultureInfo.InvariantCulture.NumberFormat), double.Parse(coordinateParts[1], CultureInfo.InvariantCulture.NumberFormat));
                coordinates.Add(coordinate);
            }
            Line line = new Line();
            line.Coordinates = coordinates;
            return line;
        }
    }

    public override string CoordinatesToWkt()
    {
        string wkt = "LINESTRING (";
        wkt += this.ToString();
        wkt += ")";
        return wkt;
    }
    
    
}


























