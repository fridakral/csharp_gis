namespace Triangles.models;
/// <summary>
/// 2 Dimensional coordinate
/// </summary>
public class Coordinate
{
    /// <summary>
    /// X part of the coordinate
    /// </summary>
    public double X {get;set;}
    /// <summary>
    /// Y part of the coordinate
    /// </summary>
    public double Y{get;set;}

    /// <summary>
    /// Constructor accepting both x and y coordinates
    /// </summary>
    /// <param name="x">x coordinate</param>
    /// <param name="y">y coordinate</param>
    public Coordinate(double x, double y){
        X = x;
        Y = y;
    }

    public void DisplayInfo(){
        Console.WriteLine($"x: {X}, y: {Y}");
    }

}