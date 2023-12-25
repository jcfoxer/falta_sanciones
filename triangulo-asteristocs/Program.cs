using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo_asteristocs
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            for (int y = 1; y <= a; y++)
            {
                for (int x = 1; x <= a - y; x++)
                {
                    Console.Write("");
                }

                for (int x = 1; x <= y; x++)
                {
                    Console.Write("*");
                }

                for (int x = 1; x <= y - 1; x++)
                {
                    Console.Write("*");
                }


            }

        }
    }
}




            
    

