using MyOwnDictionary;
using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>();
            dictionary1.Add(3,"Ali");
            dictionary1.Add(14, "Mehmet");
            //Console.WriteLine(dictionary1.GetValueOrDefault(3));
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(6,"AHMET");
            myDictionary.Add(15,"MEHMET");
            Console.WriteLine(myDictionary.Count);
            myDictionary.List();
        }
    }
}
