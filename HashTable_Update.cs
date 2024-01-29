using System;
using System.Collections;
using System.Collections.Generic;

public class UpdateHash
{
    public static void Main()
    {
        var cities = new Hashtable()                                   //Hashtable creation using collection-initializer
        {
            {"India", "Mumbai, New Delhi, Pune"},
            {"UK", "chicago, New York, Wasington"},
            {"USA", "London, Manchester, Brimingham"}
        };

        string citiesOfUK = (string) cities["UK"];                        //cast ti string 
        string citiesOfUSA = (string) cities["USA"];

        cities["UK"] = "Liverpool, Bristol";         //update value of UK key
        cities["USA"] = "Los Angeles, Boston";        

        if(!cities.ContainsKey("France"))
        {
            cities["France"] = "Paris";
        }

        foreach(DictionaryEntry de in cities)
        {
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }
 
    }
}