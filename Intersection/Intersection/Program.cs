using Intersection.Geometry;


Point point = Point.ReadFromWkt("..\\..\\..\\assets\\point.txt");

Line line = Line.ReadFromWkt("..\\..\\..\\assets\\line.txt");

Polygon polygon = Polygon.ReadFromWkt("..\\..\\..\\assets\\poly.txt");

Console.WriteLine(polygon.CoordinatesToWkt());
Console.WriteLine(line.CoordinatesToWkt());
Console.WriteLine(point.CoordinatesToWkt());