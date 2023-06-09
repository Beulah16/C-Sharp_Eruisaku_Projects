﻿using System;
namespace Mosh
{
    class FiveNum
    {
        static void Main(string[]args)
        {
            /*Write a program and ask the user to enter 5 numbers. 
              If a number has been previously entered, 
              ...display an error message and ask the user to re-try. 
              Once the user successfully enters 5 unique numbers, 
              ...sort them and display the result on the console.*/
              Console.WriteLine("Enter 5 numbers: ");
              var numArr = new int[5];
              for(var i = 0; i < numArr.Length; i++)
              {
                var num = Convert.ToInt32(Console.ReadLine());
                if(numArr.Contains(num))
                {
                    Console.WriteLine($"You've previously entered {num}");
                    i--;
                }
                else
                {
                    numArr[i] = num;
                }
              }
             Array.Sort(numArr);
             Console.WriteLine("Numbers in sorted format: {0}", string.Join(',', numArr));
        }
    }
}
