using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_Impares_Consecutivos_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir.
            //Cada caso de teste consiste de dois inteiros X e Y. Você deve apresentar a soma
            //de Y ímpares consecutivos a partir de X inclusive o próprio X se ele for ímpar. Por exemplo:
            //para a entrada 4 5, a saída deve ser 45, que é equivalente à: 5 + 7 + 9 + 11 + 13
            //para a entrada 7 4, a saída deve ser 40, que é equivalente à: 7 + 9 + 11 + 13

            //ENTRADA:
            //A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir.
            //Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.

            //Saida:
            //Imprima a soma dos consecutivos números ímpares a partir do valor X.
            
            int soma = 0;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] Impares = Console.ReadLine().Split(' ');
                int X = int.Parse(Impares[0]);
                int Y = int.Parse(Impares[1]);

                for(int cont = 1; cont <= Y; cont++)
                {
                    if(X % 2 != 0)
                    {
                        
                        soma = soma + X;
                    }
                    else
                    {
                        cont = cont - 1;
                    }
                    X++;
                }
                Console.WriteLine(soma);
                soma = 0;
            }
            Console.ReadKey();
        }
    }
}
