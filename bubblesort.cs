using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlyssaBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                    #0  #1  #2  #3
                    -----------------
                    3   3   1   1
                    10  1   3   3
                    1   10  4   4
                    56  4   9   9
                    4   9   10  10
                    9   56  56  56                          
             */

            int[] numbers = { 3, 10, 1, 56, 4, 9 };


            for (int o = 0; o < numbers.Length; o++)
            {
                Console.WriteLine("{0}", numbers[o]);
            }

            //int temp = numbers[0];
            //numbers[0] = numbers[1];
            //numbers[1] = temp;

            bool switched;


            do
            {
                switched = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        switched = true;
                    }
                }
            } while (switched);

            Console.Write("\n \n");

            for (int j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine("{0}", numbers[j]);
            }

            Console.ReadKey();
        }
    }
}
