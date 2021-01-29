using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
       
            var evens = new List<int>();
            var odds = new List<int>();

            /*
           foreach(var num in numbers)
            {
                if (num %2 == 0)
                {
                    evens.Add(num);

                }
                else
                {
                    odds.Add(num);
                }
            }*/

          for (int i =0; i<numbers.Length; i++)
            {
                if (numbers[i] % 2==0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }

            }


          foreach( var evensNumber in evens)
            {
                Console.WriteLine(evensNumber + " IS EVEN NUMBER");
            }

          foreach(var OddsNumber in odds)
            {
                Console.WriteLine(OddsNumber +" IS ODD NUMBER");
            }

          
        }
    }
}
