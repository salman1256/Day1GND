using System;
using System.Collections.Generic;
namespace GenericCollectionsEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> names = new Dictionary<int, string> {
            //    { 1,"Sam"},
            //    { 3,"Rajiv"},
            //    { 4,"Mohit"},
            //    { 10,"Nisha"},
            //    { 2,"Gauri"} };
            //Console.WriteLine("Dictionary of Names!!!");
            ////Console.WriteLine("Key \t Value ");
            //foreach (var k in names.Keys)
            //{
            //    Console.WriteLine(k + "\t " + names[k]);
            //}
            //foreach (KeyValuePair<int,string> v in names)
            //{
            //    Console.WriteLine(v);
            //}
            SortedList<int, string> sortednames = new SortedList<int, string> {
                { 1,"Sam"},
                { 3,"Rajiv"},
                { 4,"Mohit"},
                { 10,"Nisha"},
                { 2,"Gauri"} };
            Console.WriteLine("Sorted List of Names!!!");
            Console.WriteLine("Key \t Value \t Index  ");
            foreach (var k in sortednames.Keys)
            {
                Console.WriteLine(k + "\t " +sortednames[k] + "\t"+sortednames.IndexOfKey(k));
            }
            // I want to check if a particular Key exist inside sortedNames or not , If exist I want to display that name
            Console.WriteLine("Enter name to find out details");
            string n = Console.ReadLine();
            if (sortednames.ContainsValue(n))
            {
                Console.WriteLine("Record found Details as follows!!!");
                Console.WriteLine("Name "+n +"\n Index "+sortednames.IndexOfValue(n));
            }
            else
            { Console.WriteLine("No such Id exist!!!");          }
            Console.ReadKey();

        }
    }
}
