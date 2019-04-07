using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.LINQGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var tvercol = Enumerable.Range(0, 1000);
            var numgroup = from i in tvercol
                           group i by i.ToString().Length;
            foreach (IGrouping<int, int> item in numgroup)
            {
                Console.WriteLine($"Group N_{item.Key}");
                foreach (var t in item)
                {
                    Console.Write(t+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
