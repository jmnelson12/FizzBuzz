using System;
using System.Linq;
using System.Collections.Generic;

namespace FizzBuzzGenerator
{
    public static class FizzBuzz
    {
        public delegate void Callback(string value);

        public static void Generate(int upperLimit, Callback callback)
        {
            /*
             Usage Example:

                FizzBuzz.Generate(20, value =>
                {
                    Console.WriteLine(value);
                });
             
             */

            if (upperLimit < 1)
            {
                callback("Please use integer that is >= 1");
            }
            else
            {
                for (int i = 1; i <= upperLimit; i++)
                {
                    string value;
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        value = "fizzbuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        value = "fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        value = "buzz";
                    }
                    else
                    {
                        value = i.ToString();
                    }

                    callback(value);
                }
            }

        }

        public static void Generate(int upperLimit, List<Tuple<int, string>> numberWordPairs, Callback callback)
        {
            /*
                Usage Example:

                    var numberWordPairs = new List<Tuple<int, string>>
                    {
                        new Tuple<int, string> (3, "Jake"),
                        new Tuple<int, string> (5, "Jacob"),
                        new Tuple<int, string> (45, "Timmy"),
                    };

                    newClassLib.Generate(20, numberWordPairs, value =>
                    {
                        Console.WriteLine(value);
                    });
            */

            if (upperLimit < 1)
            {
                callback("Please use integer that is >= 1");
            }
            else if (numberWordPairs.Count() == 0)
            {
                callback("Please add values for your number and word pairs");
            }
            else
            {
                for (int i = 1; i <= upperLimit; i++)
                {
                    var x = numberWordPairs.Where(n => i % n.Item1 == 0);
                    string value;

                    if (x.Count() == 0)
                    {
                        value = i.ToString();
                    }
                    else
                    {
                        value = string.Join("", x.Select(e => e.Item2));
                    }

                    callback(value);
                }
            }
        }
    }
}
