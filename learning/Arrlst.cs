using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal class Arrlst
    {
        public void Arrest1()
        {
            int[] Ar = new int[] { 1, 2, 3, 4,5,6};
            //length
            Console.WriteLine("Length: "+Ar.Length);
            foreach (int i in Ar) { Console.WriteLine(i); }
            //indexof
            var b = Array.IndexOf(Ar, 6);
            Console.WriteLine("Index of 6 is:" + b);
            //copy
            int[] A = new int[6];
            Array.Copy(Ar,A,6);
            foreach(int i in A) { Console.WriteLine(i); }
            //sort
            Array.Sort(A);
            foreach (int i in A) { Console.WriteLine(i); }
            //reverse()
            Array.Reverse(A);
            foreach (int i in A) { Console.WriteLine(i); }
            //clear()
            Array.Clear(A);
            foreach(int i in A) { Console.WriteLine(i); }
        }
        public void Arrest2()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
         
            //add()
            numbers.Add(7);
            //addrange
            numbers.AddRange(new int[ 2]{ 8,9});
            //remove
            numbers.Remove(8);
            //indexof
            Console.WriteLine("the indexof 7 is"+ numbers.IndexOf(7));
            numbers.Add(4);
            foreach (int i in numbers) { Console.WriteLine(i); }
            //lastindexof
            Console.WriteLine("the last indexof 4 is:"+numbers.LastIndexOf(4));
            //Remove
            numbers.Remove(3);

            foreach(int i in numbers) { Console.WriteLine(i); }
            //Clear
            numbers.Clear();
            var s =numbers.Count();
            Console.WriteLine("count is:"+s);

        }
    }
}
