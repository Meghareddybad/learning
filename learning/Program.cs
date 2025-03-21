using learning;
using Microsoft.Win32.SafeHandles;
using System;
using System.Security.Cryptography.X509Certificates;
namespace Iteration
{
    class Program
    {
         static void Main(string[] args)
        {

            /* Smile smile = new Smile();
            smile.Smile1();
             Excercise1 excercise = new Excercise1();
            excercise.E1();
            Program two = new Program();
            two.Main1();
            Exercise2 exercise2 = new Exercise2();
            exercise2.E25();
            Arrlst arrlst = new Arrlst();
            arrlst.Arrest2();
            ex4 ex = new ex4();
            ex.E41(); 
              Her i = new Her();
            i.addit();*/

            Human h = new Human();
            string N = "lost";
            h.eat();
            h.sleep();
            h.walk(N);
            h.test();
           

          

        }
        static void mega()
        {
            string M = "megha";
            Console.WriteLine("its nme"+M);
        }
        public void Main1()
        {
            var name = "John Smith";
            int j = name.Length;
            for (var i = 0; i < j; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
        public void Main2()
        {
            var name = "John smith";
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
        }
        public void Main3()
        {
            var names = new int[] { 1, 2, 3, 4 };
            foreach (var name in names)
            { Console.WriteLine(name); }
        }
    }
}