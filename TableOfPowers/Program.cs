using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;

            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("");


            while (yesNo == true)
            {
                try
                {
                    Console.Write("Enter an integer: ");
                    int x = 0;
                    string xString;
                    xString = Console.ReadLine();
                    x = int.Parse(xString);

                    Console.WriteLine("Number     Squared      Cubed");
                    Console.WriteLine("======     =======      =====");

                    for (int i = 1; i < (x + 1); i++)
                    {
                        
                        Console.WriteLine(String.Format("  {0,-10}  {1,-10}  {2,-10}", i, (i * i), (i * i * i)));
                    }
                    Console.WriteLine();

                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not an interger");
                }


                Console.Write("Continue? (y/n): ");
                string entry = Console.ReadLine() ;
                while (entry.ToLower() != "n" || entry.ToLower() != "y" || entry.ToLower() != "no" || entry.ToLower() != "yes")
                {
                    if (entry.ToLower() == "n" || entry.ToLower() == "no")
                    {
                        yesNo = false;
                        ///entry = "n";
                        break;
                    }
                    else if (entry.ToLower() == "y" || entry.ToLower() == "yes")
                    {
                        yesNo = true;
                        ///entry = "y";
                        break;
                    }
                    else
                    {
                        Console.Write("That is not a valid answer, Continue? (y/n): ");
                        entry = Console.ReadLine();
                    }
                }

            }
        }
    }
}
