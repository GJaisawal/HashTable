using System;
using System.Collections;

public class hashtable
{
    public static void Main()
    {
        Hashtable numberName = new Hashtable();           //Hashtable Creation

        numberName.Add(1,"One");                          //Adding a key/value using the Add() method
        numberName.Add(2,"Two");
        numberName.Add(3,"Three");

        foreach(DictionaryEntry de in numberName)
        {
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }

        //Hashtable creation using collection-initializer syntax

        var cities = new Hashtable()
        {
            {"India", "Mumbai, New Delhi, Pune"},
            {"UK", "chicago, New York, Wasington"},
            {"USA", "London, Manchester, Brimingham"}
        };

        foreach(DictionaryEntry de in cities)
        {
            Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
        }
    }
}