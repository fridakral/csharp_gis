using System.Globalization;

namespace Triangles.models;

public static class CoordinateParser
{
    public static List<Coordinate> Parse (string filePath)
    {
        var poly = new List<Coordinate>();
        string wktPoly = File.ReadAllText(filePath);

        string[] splitwkt = wktPoly.Split('(');
        wktPoly = splitwkt[2];
        splitwkt = wktPoly.Split(')');
        wktPoly = splitwkt[0];
        splitwkt = wktPoly.Split (',');

        foreach(string coords in splitwkt) 
        {
            string[] splitCoords = coords.Trim().Split(' ');

            double x = double.Parse (splitCoords[0], CultureInfo.InvariantCulture.NumberFormat);
            double y = double.Parse (splitCoords[1], CultureInfo.InvariantCulture.NumberFormat);

            Coordinate coordinate = new Coordinate (x,y);
            poly.Add(coordinate);
        }

        return poly;
    }
}