using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> dictionary = new MyDictionary<string>();

            dictionary.Add("Türkiye");
            dictionary.Add("Azerbaycan");
            dictionary.Add("Yunanistan");
            dictionary.List();
            Console.WriteLine(dictionary.Count);
        }
    }
}