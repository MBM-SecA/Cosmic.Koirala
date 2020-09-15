using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte> {2,3};
            ages.Add(21);
            ages.Add(71);
            ages.Add(51);
            ages.Add(11);
            
            List<Country> countries = new List<Country>();
            Country country1 = new Country();
            countries.Add(country1);

        }
        public void LearnDictionary()
        {
            var countryCapitals = new Dictionary<string, string>
            {
                ["Pakistan"] = "Karachi",
                ["Nepal"] = "Kathmandu",
                ["Bharat"] = "Bihar"

            };

    foreach(var country in countryCapitals)
    {
        Console.WriteLine($"Country : {country.Key} Capital City : {country.Value}");
    }

        }
    }

    public class Country
    {
        public string Name {get; set; }
    }
}