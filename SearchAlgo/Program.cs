using CitySearch;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
//using CitySearch;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Search String Pattern");
        string searchString = Console.ReadLine();
        List<string> initialCities = new List<string>();
        bool flag = true;
        int i = 0;
        Console.WriteLine("Enter the name of cities (Press enter for each city name. Press ! when you are done.");
        while (flag)
        {
            initialCities.Add(Console.ReadLine());
            if (initialCities[i] == "!")
            {
                flag = false;
                initialCities.Remove(initialCities.Last());
            }
            i++;
        }
        CitySearchMain findCitiesWithNextLetters = new CitySearchMain();
        var citySearch = findCitiesWithNextLetters.LinearSearch(searchString, initialCities);

        var nextCities = citySearch.Item1;
        var nextChars = citySearch.Item2;

        Console.WriteLine("Cities that their firest letters match the Search String Pattern\n");
        foreach (var cities in nextCities)
            Console.WriteLine(cities);
        Console.WriteLine();
        Console.WriteLine("Cities that their firest letters match the Search String Pattern\n");
        foreach (var chars in nextChars)
            Console.WriteLine(chars);
    }
}
