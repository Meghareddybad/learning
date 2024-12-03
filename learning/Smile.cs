using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
     class Smile
    {
        public void Main()
        {
            
            while(true)
            {
                Console.WriteLine("enteryour name;");
                var input = Convert.ToInt32(Console.ReadLine());
              
                if (input != 0)
                {
                    Console.WriteLine("@echo = " + input);
                    continue;
                }
                else
                { Console.WriteLine("Please enter a name"); }
                break;
            }
           
        }
        public void Main2() 
        {
            var Random = new Random();
            
            Console.WriteLine(Random.Next(1, 10));
        }

    }
}
