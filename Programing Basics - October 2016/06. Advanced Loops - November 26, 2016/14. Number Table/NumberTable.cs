﻿namespace _14.Number_Table
{
    using System;

    public class NumberTable
    {
        // Напишете програма, която въвежда цяло число n и отпечатва таблица (матрица) от числа. 

        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = row + col + 1;

                    if (num > n)
                    {
                        num = (2 * n) - num;
                    }

                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }
    }
}