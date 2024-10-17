namespace Intersection;

public class FileReader
{
    public static string ReadFile(string path)
    {
        return File.ReadLines(path).First();
    }
}