﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ParamsDEmo
    {
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }
        public static void Main()
        {
            int x;
            try
            {
                Console.WriteLine("enter a number");
                x = int.Parse(Console.ReadLine());
                if (x > 10000)
                    throw new InvalidDataException("Number is not in range...");
            
                Console.WriteLine(Sum(1, 2, 3, x));
            }
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("please enter a number <=10000");//user friendly messages
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("please enter a valid number");//user friendly messages
            //}
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, error occured...contact admin");
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
            }
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine(Sum(a));
        }
    }
}
