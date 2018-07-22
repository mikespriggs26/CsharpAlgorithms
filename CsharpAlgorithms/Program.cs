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
            //int[] array = new int[] { 73, 67, 38, 33 };
            //int[] array2 = new int[array.Length];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] < 38)
            //    {
            //        array2[i] = array[i];
            //    }
            //    else
            //    {
            //        if (array[i] % 5 == 0)
            //        {
            //            array2[i] = array[i];
            //        }
            //        else if(array[i] % 5 == 3)
            //        {
            //            array2[i] = array[i] + 2;
            //        }
            //        else if(array[i] % 5 == 4)
            //        {
            //            array2[i] = array[i] + 1;
            //        }
            //        else if(array[i] % 5 < 3)
            //        {
            //            array2[i] = array[i];
            //        }
            //    }
            //}
            //foreach (var item in array2)
            //{
            //    Console.WriteLine(item);
            //}

            //*****************Apple and Orange**************SUCCESS!!!
            //int[] apples = new int[] { -2,2,1 };
            //int[] oranges = new int[] { 5,-6};
            //int appleCounter = 0;
            //int orangeCounter = 0;            

            //int s = 7;  //start of house
            //int t = 11;  //end of house
            //int a = 5;  //location of apple tree
            //int b = 15;  //location of orange tree

            //for (int i = 0; i < apples.Length; i++)
            //{
            //    if (apples[i] + a >= s && apples[i] + a <= t)
            //    {
            //        appleCounter++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //for (int i = 0; i < oranges.Length; i++)
            //{
            //    if (oranges[i] + b >= s && oranges[i] + b <= t)
            //    {
            //        orangeCounter++;
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //Console.WriteLine(appleCounter);
            //Console.WriteLine(orangeCounter);

            //************Kangaroo***************SUCCESS!!!
            //int x1 = 0;  //kangaroo1 start position
            //int v1 = 3;  //kangaroo1 jump distance
            //int x2 = 4;  //kangaroo2 start position
            //int v2 = 2;  //kangaroo2 jump distance
            //int landingSpot1 = x1 + v1;
            //int landingSpot2 = x2 + v2;
            //bool isSameSpot = false;

            //for (int i = 0; i < 10000; i++)
            //{
            //    if (landingSpot1 == landingSpot2)
            //    {
            //        isSameSpot = true;
            //        break;
            //    }
            //    else
            //    {
            //        landingSpot1 += v1;
            //        landingSpot2 += v2;
            //    }
            //}
            //if (isSameSpot == true)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            //*************Birthday Chocolate
            int[] s = new int[] { 1, 2, 1, 3, 2 };
            int m = 3;
            int d = 2;
            int sum = 0;
            int counter = 0;

            for(int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < d; j++)
                {
                   
                    sum += s[i + j];
                }
                Console.WriteLine(sum);
                if(sum == m)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            Console.ReadKey();
            
        }
    }
}
