Console.WriteLine("Enter a number: ");
var number = Console.ReadLine();
if (!int.TryParse(number, out var result) || result < 1)
{
    Console.WriteLine("Invalid integer.");
}
else
{
    List<int> prims = [];
    var num = 0;

    while (prims.Count < result)
    {
        var isPrim = !(num < 2);
        for (var i = 2; i <= Math.Sqrt(num); i++)
        {
            if(num % i == 0) isPrim = false;
        }
        if (isPrim) prims.Add(num);
        ++num;
    }

    Console.WriteLine(prims.Last());
}