using System;
using System.Collections;
using System.Collections.Generic;

public class RemoveHash
{
    public static void Main()
    {
        var cities = new Hashtable()
        {
            {"India", "Mumbai, New Delhi, Pune"},
            {"UK", "chicago, New York, Wasington"},
            {"USA", "London, Manchester, Brimingham"}
        };

        Console.WriteLine(cities.Count);

        cities.Remove("UK");                                                              //removes UK
        Console.WriteLine(cities.Count);

        if(cities.ContainsKey("France"))                            //check before removing it
        {
            cities.Remove("France");
        }

        cities.Clear();                                              //remove All element
        Console.WriteLine(cities.Count);
    }


}