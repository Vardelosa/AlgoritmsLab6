using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg6
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<int> hs = new HashTable<int>(20);
            hs.Add("mama", 5);
            hs.Add("ababagalamaga", 7);
            hs.Delete("mama");
            int n = hs.Search("mama");
            hs.Search("dasdas");
            //Console.WriteLine(n);
            //Console.WriteLine(115%16);
            Console.ReadKey();
        }
    }
}
