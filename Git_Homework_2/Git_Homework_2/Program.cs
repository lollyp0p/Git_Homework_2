using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Git_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, counter = 0,z;
           

            for (int i = 0; i == counter; i++)
            {
                try
                {
                    Console.Write("\n Enter please first number:  ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.Write(" Enter please second number: ");
                    y = Int32.Parse(Console.ReadLine());

                    z = x * y;

                    Console.WriteLine("\n x * y = " + z);


                    if (z <= 0) Console.WriteLine(" Sorry, no asterisks!");
                    else
                    {
                        for (int asterisks = 1; asterisks <= z; asterisks++)
                        {
                            Console.WriteLine(" " + asterisks + ". *");
                        }
                    }


                }
                catch (Exception error)
                {
                    Console.WriteLine("\n " + error.Message);
                    counter++;
                }
            }

            Console.ReadKey();

        }
    }
}
