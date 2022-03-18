using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0700_copiadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cálcular o valor das cópias:\n\n        até 199 cópias, $0,50 por folha;\na partir de 200 cópias, $0,30 por folha.");
            
            Console.WriteLine();

            Console.Write("Número de cópias: ");
            int c = int.Parse(Console.ReadLine());
                        

            if (c >= 200)
            {

                Console.Write("\nTotal das cópias: $" + c * 0.3f);

            }
            else
            {
                
                Console.Write("\nTotal das cópias: $" + c * 0.5f);

            }

            Console.ReadLine();
        }
    }
}
