using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
     class Smile
    {
        public void Smile1()
        {
            
            while(true)
            {
                Console.WriteLine("enteryour name;");
                var input = Console.ReadLine();
              
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@echo = " + input);
                    continue;
                }
                else
                { Console.WriteLine("Please enter a name"); }
                break;
            }
           
        }
        public void Smile2() 
        {
            var Random = new Random();
            
            Console.WriteLine(Random.Next(1, 10));
        }

    }
}
