using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();

            List<Divisiblity> divs = new List<Divisiblity>();
            Divisiblity div = new Divisiblity(3, "fizz");
            divs.Add(div);
            div = new Divisiblity(5, "buzz");
            divs.Add(div);
            div = new Divisiblity(8, "pop");
            divs.Add(div);

            fb.DoIt(100, divs, Console.Out);

            /*
            another caller, perhaps from a non-Console application could call DoIt as follows to get results to a file
            using (var sw = new StreamWriter("file.txt"))
            {
                fb.DoIt(40000, divs, sw);
            }
            */

            // leave the Console up while the caller looks at the results
            Console.WriteLine("... done. Press a key when you are done reviewing results.");
            Console.ReadLine();

        }
    }
}
