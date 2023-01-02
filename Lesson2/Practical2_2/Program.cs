// See https://aka.ms/new-console-template for more information
// 2.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно
using System;

namespace MultipleChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Check if num2 is a multiple of num1
            if (num2 % num1 == 0)
            {
                Console.WriteLine("The second number is a multiple of the first.");
            }
            else
            {
                Console.WriteLine("The second number is not a multiple of the first. Reminder: " + (num2 % num1));
            }
        }
    }
}
