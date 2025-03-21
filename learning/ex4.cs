using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    public class ex4
    {
        public void E41()
        {
            /**Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: *Consecutive"; otherwise, display "Not Consecutive".*/
            Console.WriteLine("enter a few numbers separated by a hyphen");
           // List<int> Ar=new List<int>();
            var input = Console.ReadLine();
            /*foreach (var num in input.Split('-')) ;
            Ar.Add(Convert.ToInt32(num));*/
            List<string> Arq = input.Split(',').ToList();
            bool res = true;
            for (int i=0;i<Arq.Count-1;i++)
            {
                if ((Arq[i+1] != (Arq[i] + 1)))
                { res = false;
                    break;
                }
            }
            var result = (res) ? "Consecutive" : "Non consecutive";
            Console.WriteLine(result);
           

        }
    }
}
