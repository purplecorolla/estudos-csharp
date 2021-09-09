using System;

namespace exercicio3_estrutura_condicional {
    class Program {
        static void Main(string[] args) {

            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
ordem crescente ou decrescente*/

            Console.WriteLine("Insira dois valores: ");

            String[] valor = Console.ReadLine().Split(' ');
            int x = Convert.ToInt32(valor[0]);
            int y = Convert.ToInt32(valor[1]);

            if (x % y == 0 || y % x == 0) {
                Console.WriteLine("Sao multiplos");
            }
            else {
                Console.WriteLine("Nao sao multiplos");
            }



        }
    }
}
