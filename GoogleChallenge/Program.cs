using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> letters = new List<string>();
            letters.Add("S");
            letters.Add("u");
            letters.Add("p");
            letters.Add("e");
            letters.Add("r");
            letters.Add("c");
            letters.Add("a");
            letters.Add("l");
            letters.Add("i");
            letters.Add("f");
            letters.Add("r");
            letters.Add("a");
            letters.Add("g");
            letters.Add("i");
            letters.Add("l");
            letters.Add("i");
            letters.Add("s");
            letters.Add("t");
            letters.Add("i");
            letters.Add("c");
            letters.Add("e");
            letters.Add("x");
            letters.Add("p");
            letters.Add("i");
            letters.Add("a");
            letters.Add("l");
            letters.Add("i");
            letters.Add("d");
            letters.Add("o");
            letters.Add("c");
            letters.Add("i");
            letters.Add("o");
            letters.Add("u");
            letters.Add("s");
            foreach (string letter in letters)
            {
                if (letter != "i")
                {
                    Console.WriteLine("Not an i");
                }
                else
                {
                    Console.WriteLine(letter);
                }

                string a = "supercalifragilisticexpialidocious";
                a.Count(char.IsLetter);
                Console.WriteLine();
                
            }

            Console.ReadKey();


        }
    }
}
