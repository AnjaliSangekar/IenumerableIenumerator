using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableIenumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> year = new List<int>();
            year.Add(1990);
            year.Add(1991);
            year.Add(1992);
            year.Add(1993);
            year.Add(2000);
            year.Add(2001);
            year.Add(2002);
            year.Add(2003);

            //IEnumerable<int> ienum = (IEnumerable<int>)year;    
            //foreach (int i in ienum)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine();
            IEnumerator<int> ienumerator = year.GetEnumerator();

            //while (ienumerator.MoveNext())
            //{
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}           

            Iterate19to20(ienumerator);

        }

        static void Iterate19to20(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
                if(Convert.ToInt16(o.Current) > 2000)
                {
                    Iterate19to20(o);
                }
            }
            //Console.WriteLine();
        }

        
        static void Iterate20to03(IEnumerator<int> o)
        {
            while(o.MoveNext())
            {
                Console.WriteLine(o.Current.ToString());
            }
        }
    }
}
