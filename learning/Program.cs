using Microsoft.Win32.SafeHandles;
using System;
namespace Iteration
{
    class Program
    {
         static void Main(string[] args)
        {
            var name = "John Smith";
            int j = name.Length;
            for (var i = 0; i < j; i++)
            {
                Console.WriteLine(name[i]);
            }
            Program two = new Program();
            two.Two();
            Program three = new Program();
            three.Three();
            Smile smile = new Smile();
            smile.Main();
          


            
        }
        public void Two()
        {
            var name = "John smith";
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
        }
        public void Three()
        {
            var names = new int[] { 1, 2, 3, 4 };
            foreach (var name in names)
            { Console.WriteLine(name); }
        }
    }
}