using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//array in C# is a group of similar types of elements that have contiguous memory location.
//array is an object of base type System.Array.
//array index starts from 0.
//There are 3 types of arrays in C# programming:

//Single Dimensional Array
//Multidimensional Array
//Jagged Array

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration
            // int[] a = new int[50];
            // string[] b = new string[900];
            // string[] b = { "s", "sdsd","abc","kl"};// declaring & initializing array

            //Initialization
            //a[0] = 10;
            //a[1] = 20;
            //a[2] = 30;

            //for(int i=1;i<=3;i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //for(int j=0;j<4; j++)
            //{
            //    Console.WriteLine(b[j]);
            //}
            //foreach(string k in b)
            //{
            //    Console.WriteLine(k);
            //}

            //*************ARRAY TO FUNCTION**************////////////
            //    Program p = new Program();
            //    int[] cba = {454,5656,898,565,2,2,3,45,89,12};
            //    p.show(cba);

            //    Console.ReadKey();

            //}
            //public void show(int[] abc)
            //{
            //    Console.WriteLine("PRINTIG ELEMENTS OF ARRAAYS");
            //    for(int i =0;i<abc.Length;i++)
            //    {
            //        Console.WriteLine(abc[i]);
            //    }
            //}
            ///***************************************************/////////
            ///

            ///*********************Multidimentional Array**************/////////////////////


            // int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            // int[,] rr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // int[,] qq = { { }, { }, { } };
            // int[] a = new int[50];
            // int[,] aa = { { 78, 454, 12 },{ 78,5,6},{ 789,45,2 } }; 
            //for(int i=0;i<3;i++)
            // {
            //     for(int j=0;j<3;j++)
            //     {
            //         Console.WriteLine(aa[i,j] + "");
            //     }
            // }

            /////////////////////************************Jagged arrays*****************************////////////////
            //int[][] arr = new int[2][];
            //int[][] brr = new int[2][];
            //arr[0] = new int[4];
            //arr[1] = new int[2];


            //string[][] jaggedarray=new string[3][];
            //jaggedarray[0] = new string[3];
            //jaggedarray[1] = new string[1];
            //jaggedarray[2] = new string[2];

            //jaggedarray[0][0] = "bachlors";
            //jaggedarray[0][2] = "doctrate";

            //jaggedarray[1][0] = "bachlors";

            //jaggedarray[2][0] = "bachlors";
            //jaggedarray[2][1] = "masters";

            //for(int i=0;i<jaggedarray.Length;i++)
            //{
            //    for(int j = 0; j < jaggedarray[i].Length; j++)
            //    {
            //        Console.WriteLine(jaggedarray[j]);
            //    }
            //    Console.WriteLine();
            //}

            //*****************COMMAND LINE arguments*********************/////////////

            //Console.WriteLine("Argument length: " + args.Length);
            //Console.WriteLine("Supplied Arguments are:");
            //foreach (Object obj in args)
            //{
            //    Console.WriteLine(obj);
            //}

            {
                //// Creating an array  
                //int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };
                //Console.WriteLine(" index of is {0}", + Array.IndexOf(arr, 25));
                //// Creating an empty array  
                //int[] arr2 = new int[6];
                //// Displaying length of array  
                //Console.WriteLine("length of first array: " + arr.Length);
                //// Sorting array  
                //Array.Sort(arr);
                //Console.Write("First array elements: ");
                //// Displaying sorted array  
                //PrintArray(arr);
                //// Finding index of an array element  
                //Console.WriteLine("\nIndex position of 25 is " + Array.IndexOf(arr, 25));
                //// Coping first array to empty array  
                //Array.Copy(arr, arr2, arr.Length);
                //Console.Write("Second array elements: ");
                //// Displaying second array  
                //PrintArray(arr2);
                //Array.Reverse(arr);
                //Console.Write("\nFirst Array elements in reverse order: ");
                //PrintArray(arr);


            }
            Console.ReadKey();
        }
        static void PrintArray(int[] arr)
        {
            foreach (Object elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}
