using System;

namespace exercicio2_estrutura_condicional {
    class Program {
        static void Main(string[] args) {

            // Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.


            int x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0) {

                Console.WriteLine("PAR");

            } else {
                Console.WriteLine("IMPAR");
            }


        }
    }
}
