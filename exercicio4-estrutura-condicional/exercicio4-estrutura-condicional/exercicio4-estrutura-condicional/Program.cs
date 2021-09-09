using System;

namespace exercicio4_estrutura_condicional {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite a hora de inicio e fim do jogo:");

            String[] valores = Console.ReadLine().Split(' ');

            int horaInicial = Convert.ToInt32(valores[0]);

            int horaFinal = Convert.ToInt32(valores[1]);

            int duracao;

            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O jogo durou " + duracao + " hora(s).");

        }
    }
}
