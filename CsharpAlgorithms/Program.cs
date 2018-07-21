using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ones = 0;
            //int twos = 0;
            //int threes = 0;
            //int fours = 0;
            //int fives = 0;

            //int[] array1 = new int[] { 1, 4, 4, 4, 5, 3 };
            //foreach (var item in array1)
            //{
            //    if(item == 1)
            //    {
            //        ones += 1;
            //    }
            //    if(item == 2)
            //    {
            //        twos += 1;
            //    }
            //    if (item == 3)
            //    {
            //        threes += 1;
            //    }
            //    if (item == 4)
            //    {
            //        fours += 1;
            //    }
            //    if (item == 4)
            //    {
            //        fives += 1;
            //    }
            //}

            //******Grading Students*****SUCCESS!!!!
            int[] array = new int[] { 73, 67, 38, 33 };
            int[] array2 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < 38)
                {
                    array2[i] = array[i];
                }
                else
                {
                    if (array[i] % 5 == 0)
                    {
                        array2[i] = array[i];
                    }
                    else if(array[i] % 5 == 3)
                    {
                        array2[i] = array[i] + 2;
                    }
                    else if(array[i] % 5 == 4)
                    {
                        array2[i] = array[i] + 1;
                    }
                    else if(array[i] % 5 < 3)
                    {
                        array2[i] = array[i];
                    }
                }
            }
            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            
        }
    }
}
