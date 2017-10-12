using System;
using System.Collections.Generic;

namespace Generici
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildDictionary();
            IterateDict();
            Console.WriteLine("string da cercare: ");
            string s = Console.ReadLine();
            FintInDictionary(s);
            Console.ReadLine();
        }

       public static Dictionary<string, Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();
            AddToDict(elements, "K", "P", 1);
            AddToDict(elements, "Ca", "Calcium", 20);
            AddToDict(elements, "Sc", "Scandium", 21);
            AddToDict(elements, "Ti", "Titanium", 22);
            return elements;
        }

        public static void AddToDict(Dictionary<string, Element> elements,
            string symbol, string name, int atomicNumber)
        {
            Element theElem = new Element();
            theElem.Symbol = symbol;
            theElem.Name = name;
            theElem.AtomicNumber = atomicNumber;

            elements.Add(key: theElem.Symbol, value: theElem);
        }
        public static void IterateDict()
        {
            Dictionary<string, Element> elements = BuildDictionary();
            foreach (KeyValuePair<string, Element> a in elements)
            {
                Element theElement = a.Value;
                Console.WriteLine("key: " + a.Key);
                Console.WriteLine("values: " + theElement.Symbol + " " +
                                  theElement.Name + " " + theElement.AtomicNumber);
            }
        }

        public static void FintInDictionary(string symbol)
        {
            Dictionary<string, Element> elements = BuildDictionary();

            if(elements.ContainsKey(symbol) == false)
                Console.WriteLine(symbol + "Not found");
            else
            {
                Element theElement = elements[symbol];
                Console.WriteLine("Found: " + theElement.Name);
            }
        }

        public class Element
        {
            public string Symbol { get; set; }
            public string Name { get; set; }
            public int AtomicNumber { get; set; }
        }
    }
}

   

   

