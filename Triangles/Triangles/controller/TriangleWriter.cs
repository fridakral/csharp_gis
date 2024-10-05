using Triangles.models;

namespace Triangles.controller;

public static class TriangleWriter
{
    public static void WriteToConsole(List<Triangle> triangles)
    {
        foreach (var triangle in triangles)
        {
            triangle.DisplayTriangle();   
        }
    }
}