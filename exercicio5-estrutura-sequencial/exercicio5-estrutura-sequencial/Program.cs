using System;
using System.Globalization;

namespace exercicio5_estrutura_sequencial {
    class Program {
        static void Main(string[] args) {

            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.*/

            int codigo1, numpecas1, codigo2, numpecas2;
            double valor1, valor2, total;

            Console.WriteLine("Digite o codigo da peca 1, numero de pecas e o valor");

            string[] valor = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(valor[0]);
            numpecas1 = int.Parse(valor[1]);
            valor1 = double.Parse(valor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo da peca 2, numero de pecas e o valor:");

            valor = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(valor[0]);
            numpecas2 = int.Parse(valor[1]);
            valor2 = double.Parse(valor[2], CultureInfo.InvariantCulture);

            total = numpecas1 * valor1 + numpecas2 * valor2;

            Console.WriteLine("Total a pagar: R$" + total.ToString("F2", CultureInfo.InvariantCulture));





        }
    }
}
