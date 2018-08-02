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
            //*************Time Conversion  SUCCESS!!!
            //string s = "01:05:45AM";
            //char a = s[0];
            //char b = s[1];
            //char c = s[8];
            //char d = s[9];
            //string segment = s.Substring(2, 6);
            //string str = a.ToString() + b.ToString();
            //string ampm = c.ToString() + d.ToString();
            //int hours = int.Parse(str);

            //if (ampm.ToLower() == "pm" && hours == 12)
            //{
            //    hours = 12;
            //}
            //else if (ampm.ToLower() == "pm")
            //{
            //    hours += 12;
            //}
            //string hour = hours.ToString();
            //if (ampm == "AM"  && hours == 12)
            //{
            //    hour = "00";
            //}
            //else if(ampm == "AM")
            //{
            //    hour = str;
            //}
            
            //string result = hour + segment;
            //Console.WriteLine(result);


            //*********Mini-Max Sum   SUCCESS!!!!
            //int[] arr = new int[] { 1, 2, 3, 4, 5, };
            //double[] arr = new double[] { 256741038, 623958417, 467905213, 714532089, 938071625 };
            //double arrSum = arr[0] + arr[1] + arr[2] + arr[3] + arr[4];
            //double minSum = arrSum;
            //double maxSum = 0;


            //for (int i = 0; i < arr.Length; i++)
            //{

            //    double testSum = arrSum - arr[i];
            //    //Console.WriteLine(testSum);
            //    if (testSum > maxSum)
            //    {
            //        maxSum = testSum;
            //    }
            //    if (testSum < minSum)
            //    {
            //        minSum = testSum;
            //    }

            //}
            //Console.WriteLine(minSum + " " + maxSum);



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

            //**************************  MIGRATORY BIRDS    SUCCESS!!!
            //int counter1 = 0;
            //int counter2 = 0;
            //int counter3 = 0;
            //int counter4 = 0;
            //int counter5 = 0;

            //int[] ar = new int[] { 1, 4, 4, 4, 5, 3 };
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    if (ar[i] == 1)
            //        counter1++;
            //    if (ar[i] == 2)
            //        counter2++;
            //    if (ar[i] == 3)
            //        counter3++;
            //    if (ar[i] == 4)
            //        counter4++;
            //    if (ar[i] == 5)
            //        counter5++;

            //}
            //int maxNum = 0;
            //int[] num = new int[] { counter1, counter2, counter3, counter4, counter5 };
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] > maxNum)
            //    {
            //        maxNum = num[i];

            //    }
            //}
            //if (maxNum == counter1)
            //    maxNum = 1;
            //else if (maxNum == counter2)
            //    maxNum = 2;
            //else if (maxNum == counter3)
            //    maxNum = 3;
            //else if (maxNum == counter4)
            //    maxNum = 4;
            //else if (maxNum == counter5)
            //    maxNum = 5;

            //Console.WriteLine(maxNum);

            //******Designer PDF Viewer          SUCCESS!!!!
            //int[] h = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            //int[] k = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7, };
            ////char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', };
            //string alphabet = "abcdefghijklmnopqrstuvwxyz";
            //string word = "zaba";
            //int maxHeight = 0;


            //for (int i = 0; i < word.Length; i++)
            //{
            //    int index = alphabet.IndexOf(word[i]);
            //    int height = k[index];
            //    if( height > maxHeight)
            //    {
            //        maxHeight = height;
            //    }
            //}
            //int area = maxHeight * word.Length;
            //Console.WriteLine(area);

            //*************Utopian Tree                 NOT SURE IF THIS IS DONE
            //int[] period = new int[] { 0, 1, 4 };

            //foreach (var item in period)
            //{

            //    int height = 1;
            //    for (int i = 0; i < item; i++)
            //    {

            //        if(i % 2 == 0)
            //        {
            //            height= height * 2;
            //        }
            //        if(i % 2 == 1)
            //        {
            //            height++;
            //        }
            //    }
            //    Console.WriteLine(height);
            //}





            //***************************       NOT SOLVED
            //int[] bill = new int[] { 3, 10, 2, 9 };
            //int n = 4;  // # of items
            //int b = 7; // what Anna paid
            //int k = 1;  // index of item not eaten
            //int sum = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    if (i == k)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        sum += bill[i];
            //    }
            //}
            //int annaShare = sum / 2;
            //if (annaShare == b)
            //{
            //    Console.WriteLine("Bon Appetit");
            //}
            //else
            //{
            //    Console.WriteLine(b - annaShare);
            //}




            //*************Birthday Chocolate             NOT SOLVED
            //int[] s = new int[] { 1, 2, 1, 3, 2 };
            //int m = 3;
            //int d = 2;
            //int sum = 0;
            //int counter = 0;

            //for(int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 0; j < d; j++)
            //    {

            //        sum += s[i + j];
            //    }
            //    Console.WriteLine(sum);
            //    if(sum == m)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);



            Console.ReadKey();
            
        }
    }
}
