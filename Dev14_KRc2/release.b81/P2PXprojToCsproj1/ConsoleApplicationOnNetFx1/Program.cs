using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationOnNetFx1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibraryOnNetFx1.Class1 c1 = new ClassLibraryOnNetFx1.Class1();
            //ClassLibraryOnNetFx2.Class1 c2 = new ClassLibraryOnNetFx2.Class1();

            Console.WriteLine(c1.GetHello());
            //Console.WriteLine(c2.GetHello());

            Console.WriteLine("Hello world");
            
        }
    }
}
