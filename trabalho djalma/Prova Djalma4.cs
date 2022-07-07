using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_djalma
{
    class Program
    {
        static void Main(string[] args)
        {
            string j = "S";

            do
            {

                Console.Clear();
                for (int i = 1; i <= 50; i++)
                {
                    Console.WriteLine(i);

                }
                Console.WriteLine();

                Console.Write("Deseja usar novamente? (Sim/Nao): ");

                j = Console.ReadLine();

                if (j != "N" && j != "n" && j != "S" && j != "s")
                {

                    Console.WriteLine("ERROR!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }


            }
            while (j == "S" || j == "s");

            Console.WriteLine("OBRIGADA POR USAR VOLTE SEMPRE :)");
            Console.ReadKey();

        }


    }
}
