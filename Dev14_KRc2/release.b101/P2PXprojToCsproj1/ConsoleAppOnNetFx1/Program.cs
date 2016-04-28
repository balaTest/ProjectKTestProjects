using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOnNetFx1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibraryOnNetFx1.Class1 c = new ClassLibraryOnNetFx1.Class1();
            Console.WriteLine($"Hello from ConsoleAppOnNetFx1 {c.GetHello()}");
        }
    }
}
