using System;

namespace exercicio3_estrutura_sequencial {
    class Program {
        static void Main(string[] args) {


            int V1, V2, V3, V4, dif;


            V1 = int.Parse(Console.ReadLine());
            V2 = int.Parse(Console.ReadLine());
            V3 = int.Parse(Console.ReadLine());
            V4 = int.Parse(Console.ReadLine());

            dif = (V1 * V2) - (V3 * V4);

            Console.WriteLine("Diferenca = " + dif);

        }
    }
}
