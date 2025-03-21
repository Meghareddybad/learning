using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class Human
    {
       private string one = "megha";
       private string two ="syam";
        private string three ="reddy";
        string name;
        string Name="varun";
        string N;
        public string Two
           {
            get { return two; }
            set { Two = two; } }
        public Human()
        {
          
            name = one;
        }
        public void test() { Console.WriteLine(Two);}

        public void eat()    {Console.WriteLine($"{name} is eating ");
            Console.WriteLine(name);
        }
        public void sleep()  {Console.WriteLine($"{Name} is sleeping");
            Console.WriteLine(Name);
        }
        public void walk(string N)   {Console.WriteLine($"{N} is walking");
            Console.WriteLine(N);
        }
    }
   
} 
