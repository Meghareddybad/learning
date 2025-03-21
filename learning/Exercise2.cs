using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace learning
{
    internal class Exercise2
    {


        public void E21()
        {
            /*Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.*/
            int a = 0;
            int b = 3;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0) { a += 1; }

            }
            Console.WriteLine("The final count = " + a);
        }
        public void E22()
        {
            /*Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.*/


            int b = 0;
            int c = 0;
            string a = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter any value for a (or) 'ok' to exit:");
                a = Console.ReadLine();
                if (a == "ok")
                {
                    Console.WriteLine("Final sum: " + c);

                    break;
                }
                else
                {
                    b = Convert.ToInt32(a);
                    c += b;
                }
            }
        }
        public int E23()
        {
            /*Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x4x3x2x1and display it as 5! = 120.*/
            int i = 0;
            int c = 1;
            Console.WriteLine("Enter any value :");
            var a = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= a; i++)
            {

                c = c * i;


            }
            return c;
        }

        public void E24()
        {
            /*Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display "You won"; otherwise, display "You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/
            var random = new Random();
            int a =random.Next(1,10);
            //Console.WriteLine(a);
            for (int i = 1; i <=4; i++)
            {
                Console.WriteLine("guess the number you have four chances(only integers):");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b == a) { Console.WriteLine("hurray you have won");break; }
                else
                { Console.WriteLine("Better luck next time , you have lost"); }

            }

        }
        public void E25()
        {
            /* Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters "5, 3, 8, 1, 4", the program should display 8? */
            Console.WriteLine("enter a series of numbers separated by comma:");
            var a = Console.ReadLine();
            string[] arr = a.Split(',');
            int[] bar = Array.ConvertAll(arr, int.Parse);
            int c = bar.Max();
            Console.WriteLine("The Output is : " + c);


        }


    }
}
