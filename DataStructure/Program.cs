using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cities = CityData();
            string line;
            do
            {
                Console.WriteLine("Enter value for search:  ");
                line = Console.ReadLine();
                if (line != null)
                    for (var i = 0; i < cities.Count; i++)
                    {
                        if (cities[i].CityName.Contains(line))
                        {
                            Console.WriteLine("Found: {0}, {1}", cities[i].CityName, cities[i].CityPopulation);
                        }

                    }

            } while (line != null);

        }

        //Cities data
        public static List<Cities> CityData()
        {
            var seattle = new Cities();
            List<Cities> cities = new List<Cities>();

            seattle.CityName = "Seattle, WA";
            seattle.CityPopulation = 652405;

            var redmond = new Cities();
            redmond.CityName = "Redmond, WA";
            redmond.CityPopulation = 57530;


            var spokane = new Cities();
            spokane.CityName = "Spokane, WA";
            spokane.CityPopulation = 208916;

            var bellevue = new Cities();
            bellevue.CityName = "Bellevue, MO";
            bellevue.CityPopulation = 200123;

            var everette = new Cities();
            everette.CityName = "Everette, WA";
            everette.CityPopulation = 133992;

            var olympia = new Cities();
            olympia.CityName = "Olympia, WA";
            olympia.CityPopulation = 48338;

            var tacoma = new Cities();
            tacoma.CityName = "Tacoma, WA";
            tacoma.CityPopulation = 133992;

            var ellensburge = new Cities();
            ellensburge.CityName = "Ellensburge, WA";
            ellensburge.CityPopulation = 18111;

            cities.Add(seattle);
            cities.Add(redmond);
            cities.Add(spokane);
            cities.Add(bellevue);
            cities.Add(everette);
            cities.Add(olympia);
            cities.Add(tacoma);
            cities.Add(ellensburge);


            return cities;
        }
    }
}
