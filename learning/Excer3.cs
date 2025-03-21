using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;

namespace learning
{
    internal class Excer3
    {
        /*- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.

If only one person likes your post, it displays: [Friend's Name] likes your post.

If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.

If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern*/




        public void DisplayLikes(List<string> names)
        {
            int numLikes = names.Count;

            if (numLikes == 0)
            {
                // No message displayed if no names are entered
                return;
            }
            else if (numLikes == 1)
            {
                Console.WriteLine($"{names[0]} likes your post.");
            }
            else if (numLikes == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post.");
            }
            else
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {numLikes - 2} others like your post.");
            }
        }

        public void Ex31()
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Enter a friend's name (or press Enter to stop): ");
                string name = Console.ReadLine();

                if (string.IsNullOrEmpty(name)) // Stop when user presses Enter without entering a name
                {
                    break;
                }

                names.Add(name);
            }

            Excer3 excer3 = new Excer3();
            excer3.DisplayLikes(names);
        }
        public void Ex32()
        {
            /*Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.*/



            // Ask the user to enter their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Convert the name to a character array
            char[] nameArray = name.ToCharArray();

            // Reverse the character array
            Array.Reverse(nameArray);

            // Create a new string from the reversed array
            string reversedName = new string(nameArray);

            // Display the reversed name
            Console.WriteLine("Reversed name: " + reversedName);

        }
        public void E33()
        {
            /*Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.*/

            List<int> sike = new List<int>(5);

            while (sike.Count < 5)
            {
                Console.WriteLine("Enter a unique numbers:");
                string a = Console.ReadLine();
                if (string.IsNullOrEmpty(a))
                {
                    Console.WriteLine("Please enter a valid number");
                }
                else if (sike.Contains(Convert.ToInt32(a)))
                {
                    Console.WriteLine("please re-enter a unique number:");

                }

                else
                {
                    int b = Convert.ToInt32(a);
                    sike.Add(b);
                }


            }
            sike.Sort();
            foreach (int s in sike)
            {
                Console.WriteLine(s);
            }
        }

        public void E34()
        {
            /**Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.*/
            List<int> kill = new List<int>();
            while (true)
            {
                Console.WriteLine(" continuously enter a number or type \"Quit\" to exit");

                string a = Console.ReadLine();
                var b = a.ToLower();
                if (b == "quit") { break; }
                else if (string.IsNullOrWhiteSpace(a)) { Console.WriteLine("please enter a valid value"); }
                else if (kill.Contains(Convert.ToInt32(a))) { }
                else { kill.Add(Convert.ToInt32(a)); }
            }

            foreach (int s in kill)
            { Console.WriteLine(s); }
        }
        public void E35()
        {
            /* Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 12, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.*/
            Console.WriteLine("supply a list of comma separated numbers (e.g 5, 1, 9, 12, 10)*must be >5 elemnets and should not enter null");
            string[] lat;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    lat = input.Split(',');
                    if (lat.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }
            Array.Sort(lat);
            for (int i = 0; i < 3; i++)
            { Console.WriteLine(lat[i]); }

        }
    }
}

   

