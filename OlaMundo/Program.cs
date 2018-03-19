using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ola Mundo", args.Length);
            Console.ReadLine();

            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
        }
    }
}
