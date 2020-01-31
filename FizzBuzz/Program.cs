using System;
using System.Collections.Generic;
using FizzBuzzGenerator;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberWordPairs = new List<Tuple<int, string>>
            {
                new Tuple<int, string> (3, "Fooz"),
                new Tuple<int, string> (5, "Baaz"),
                new Tuple<int, string> (13, "FoozyBaazy"),
            };

            // use  int.MaxValue  for max value

            FizzBuzz.Generate(100, value =>
            {
                Console.WriteLine(value);
            });
            //FizzBuzz.Generate(100, numberWordPairs, value =>
            //{
            //    Console.WriteLine(value);
            //});
        }
    }
}
