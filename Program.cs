using System;
using System.Collections.Generic;

namespace planetsandspaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            //Add planets to the List
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> newPlanetList = new List<string>() { "Neptune", "Uranus" };

            planetList.AddRange(newPlanetList);

            planetList.Insert(2, "Venus");
            planetList.Insert(3, "Earth");

            planetList.Add("Pluto");

            //create a new list for just rocky planets
            List<string> rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine("This is a list of all rocky planets in the solar system.");
            //print out each rocky planet using a foreach loop to iterate over the list that was just created.
            foreach (string rocky in rockyPlanets)
            {
                Console.WriteLine(rocky);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("This is a new list that has had Pluto removed");

            //Remove pluto from the list.
            planetList.Remove("Pluto");


            //print out the new list of planets where Pluto has been removed.
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("This is a new list that has had Mars removed");

            //Remove Mars and place it back into the list in its correct location in the solar system.
            planetList.RemoveAt(1);
            //Insert Mars into its proper location inside our solar system.
            planetList.Insert(3, "Mars");

            //print out the new list of planets where Mars has been rearranged into its proper spot in our solar system.
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
        }
    }
}
