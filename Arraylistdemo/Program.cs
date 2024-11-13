using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylistdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 30, 40, 50 };
            ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(20);

            list1.AddRange(arr);

            list1.Insert(1, 60);

          //  list1.Remove(10);
           // list1.RemoveAt(2);

            list1.RemoveRange(3, 2);
            // list1.Clear();
            Console.WriteLine("count ="+list1.Count);
            Console.WriteLine("Capasity="+list1.Capacity);

            foreach(var i in list1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
