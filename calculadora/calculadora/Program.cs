using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num01, num02, menu, soma;

            Console.WriteLine("Calculadora");
            Console.WriteLine("Qual conta vc quer fazer:");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            menu =Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Primeiro numero:");
            num01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segundo numero:");
            num02 = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    soma = num01 + num02;

                    Console.WriteLine("Resultado:" + soma);
                    Thread.Sleep(2000);
                    break;

                case 2:
                    soma = num01 - num02;

                    Console.WriteLine("Resultado:" + soma);
                    Thread.Sleep(2000);
                    break;

                case 3:
                    soma = num01 * num02;

                    Console.WriteLine("Resultado:" + soma);
                    Thread.Sleep(2000);
                    break;

                case 4:
                    soma = num01 / num02;

                    Console.WriteLine("Resultado:" + soma);
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}
