//using Triangles.models;

using Triangles.controller;
using Triangles.models;


var coordinates = CoordinateParser.Parse("..\\..\\..\\assets\\polygon.txt");

var triangles = Triangulator.Triangulate(coordinates);

TriangleWriter.WriteToConsole(triangles);