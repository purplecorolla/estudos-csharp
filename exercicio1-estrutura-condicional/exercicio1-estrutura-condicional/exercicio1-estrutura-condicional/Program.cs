using System;

namespace exercicio1_estrutura_condicional {
    class Program {
        static void Main(string[] args) {

            // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0) {
                Console.WriteLine("NAO NEGATIVO");

            } else {
                Console.WriteLine("NEGATIVO");
            }
        }
    }
}
