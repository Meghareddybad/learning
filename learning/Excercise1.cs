using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class Excercise1
    {
      public void E1()
        {
            // Write a program and ask the user to enter a number.The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)//
            
            Console.WriteLine("enter a number between 1 and 10:");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i >= 1 && i <= 10)
                Console.WriteLine("the input is within the limit");
            else
                Console.WriteLine("Input is out of bound");
        }
        public void E2()
        {
            //Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.Write("Enter any value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter any value for b:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b) 
                Console.WriteLine("a is the greatest number : " + a);
            else if (b > a) 
                Console.WriteLine("b is the greatest number : " + b);
            else 
                Console.WriteLine("Both the numbers are equal");
        }
        public void E3()
        {
            // Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait
            Console.Write("Enter length value for image:");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter breadth value for image:");
            int brd = Convert.ToInt32(Console.ReadLine());
            if (len > brd)
                Console.WriteLine("It is a portrait image");
            else if (brd > len) 
                Console.WriteLine("it is a Landscape image");
            else
                Console.WriteLine("It is a square image");

        }
        public void E4()
        {
            /*Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.*/
            Console.Write("Enter Speed limit:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of car:");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Speed of the car i within the limit");
            }
            else if (b > a)
            {
                Console.WriteLine("the speed limit exceeded");
                int c = b - a;
                int d = c / 5;
                if (d < 12)
                    Console.WriteLine("You have earned " + d + " Demerit points");
                else if (c >= 12)
                    Console.WriteLine("Licence has been suspended");
            }
            

                

        }


    }
}
