using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("Escolha uma das auternativa(quadrado, losango, retangulo, trapézio )");
            string form = Console.ReadLine().ToLower();

            Console.WriteLine("Digite o tamanho da base");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura");
            double A = double.Parse(Console.ReadLine());

           

            double med = 0;

               switch (form)
            {
                case "quadrado":
                Console.WriteLine("A area do seu quadrado é:"+ ( A * B));
                 Console.ReadKey(); 
                    break;

                case "retangulo":
                    Console.WriteLine("A area do seu retangulo é:" + (A * B));
                    Console.ReadKey();
                    break;

                case "losango":
                    Console.WriteLine("A area do seu quadrado é:" + ((A * B)/2));
                    Console.ReadKey();
                    break;

                case "trapézio":
                    Console.WriteLine("Qual a base superior do trapezio");
                   double b2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("A area do seu trapézio é:" + ((b2 + B)*A / 2));
                    Console.ReadKey();
                    break;

                 default: Console.WriteLine("Algo deu errado digite uma das alternativa");
                          Console.ReadKey();
                    break;




            }





        }
    }
}
