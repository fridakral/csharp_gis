//using Triangles.models;

using Triangles.controller;
using Triangles.models;


var coordinates = CoordinateParser.Parse("C:\\Users\\kralf\\frida\\uni\\prog\\csharp_gis\\polygon.txt");

var triangles = Triangulator.Triangulate(coordinates);

TriangleWriter.WriteToConsole(triangles);