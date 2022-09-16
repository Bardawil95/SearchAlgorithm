using System;
using System.Collections;
//using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch
{
    public interface ICityFinder
    {
        public Tuple<Collection<string>, Collection<string>> LinearSearch(string searchString, List<string> initialCities);
    }

}
