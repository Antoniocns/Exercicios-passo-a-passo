using System;
namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;

            Console.WriteLine("Digite um número de 0 a 10:");

            numero = int.Parse(Console.ReadLine());

            if (numero < 0 || numero > 10)
            {
                Console.WriteLine("Número inválido por favor digite um número de 0 a 10:");
            }
            else
            {
                while (contador < 11)
                {
                    Console.WriteLine(numero + " x " + contador + " = " + numero * contador);
                    contador = contador + 1;
                }
            }
        }
    }
}