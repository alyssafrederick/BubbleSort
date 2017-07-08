using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesortreview
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(9);
            //numbers.Add(0);
            //numbers.Add(1);
            //numbers.Add(90);
            //numbers.Add(87);
            //numbers.Add(7);

            for (int i = 0; i < 5000; i++)
            {
                numbers.Add(rand.Next());
            }




            //bubble sort
            System.Diagnostics.Stopwatch swag = System.Diagnostics.Stopwatch.StartNew();

            bool switched;
            do
            {
                switched = false;

                for (int i = 0; i < numbers.Count - 1; i++)
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
            swag.Stop();



            numbers.Clear();
            for (int i = 0; i < 5000; i++)
            {
                numbers.Add(rand.Next());
            }




            //selection sort
            System.Diagnostics.Stopwatch timer = System.Diagnostics.Stopwatch.StartNew();

            int numberWeAreAt = -1;
            int indexToSwap = -1;

            //Go through entire list of numbers
            for (int i = 0; i < numbers.Count; i++)
            {
                numberWeAreAt = numbers[i];
                indexToSwap = i;
                //Go through everything but the numbers we have covered so far Example: if i = 3 and numbers.Count = 5
                //We will only check 3-5 NOT 1-5
                for (int a = i + 1; a < numbers.Count; a++)
                {
                    if (numberWeAreAt > numbers[a])
                    {
                        indexToSwap = a;
                        numberWeAreAt = numbers[a];
                    }
                }
                //Need to swap numbers[i] and numbers[a]
                int tempp = numbers[i];
                numbers[i] = numbers[indexToSwap];
                numbers[indexToSwap] = tempp;
            }
            timer.Stop();



            numbers.Clear();
            for (int i = 0; i < 5000; i++)
            {
                numbers.Add(rand.Next());
            }



            //insertion sort
            System.Diagnostics.Stopwatch timerSwag = System.Diagnostics.Stopwatch.StartNew();

            int numberweRat = -1;        
            //Loop through entire list
            for (int i = 0; i < numbers.Count; i++)
            {
                //Store current limit value
                numberweRat = numbers[i];

                //Loop through previous values
                for (int a = i - 1; a > -1 ; a--)
                {
                    //Check if numbersweRat < the previous values then switch it w the previous vaule
                    if (numbers[a + 1] < numbers[a])
                    {
                        int tempnumber = numbers[a + 1];
                        numbers[a + 1] = numbers[a];
                        numbers[a] = tempnumber; 
                    }
                }
            }
            timerSwag.Stop();


            for (int i = 0; i < numbers.Count - 1; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine();
            Console.WriteLine(swag.ElapsedMilliseconds);
            Console.WriteLine(timer.ElapsedMilliseconds);
            Console.WriteLine(timerSwag.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
