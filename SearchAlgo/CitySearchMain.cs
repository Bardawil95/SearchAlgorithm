using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch
{
    public class CitySearchMain : ICityFinder, ICityResult
    {
        public CitySearchMain() { }

        public ICollection<string> NextLetters { get; set; }
        public ICollection<string> NextCities { get; set; }

        public Tuple<Collection<string>, Collection<string>> LinearSearch(string searchString, List<string> initialCities)
        {
            NextCities = new Collection<string>();
            NextLetters = new Collection<string>();
            for (int count = 0; count < initialCities.Count; count++)
                if (initialCities[count].Substring(0, searchString.Length) == searchString)
                {
                    NextCities.Add(initialCities[count].ToString());
                    NextLetters.Add(initialCities[count].Substring(searchString.Length, initialCities[count].Length - searchString.Length));
                }
            return Tuple.Create((Collection<string>)NextCities, (Collection<string>)NextLetters);
        }

    }
}
