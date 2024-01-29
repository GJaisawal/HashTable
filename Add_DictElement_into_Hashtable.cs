using System;
using System.Collections;
using System.Collections.Generic;
public class AddDictToHash
{
    public static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

        Hashtable ht = new Hashtable(dict);                      //Adding dictionary element into hashtable ht

        Console.WriteLine(ht.Count);

    }
}