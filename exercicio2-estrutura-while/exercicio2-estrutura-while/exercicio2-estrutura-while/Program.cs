using System;

namespace exercicio2_estrutura_while {
    class Program {
        static void Main(string[] args) {

/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

            Console.WriteLine("Digite as coordenadas: ");

            string[] valores = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(valores[0]);
            int y = Convert.ToInt32(valores[1]);

            while (x != 0 && y != 00) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");

                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                }
                else  {
                    Console.WriteLine("Quarto");
                }

                valores = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(valores[0]);
                y = Convert.ToInt32(valores[1]);
            }
        }
    }
}
