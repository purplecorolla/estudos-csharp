using System;

namespace exercicio5_estrutura_condicional {
    class Program {
        static void Main(string[] args) {

            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            seguir, calcule e mostre o valor da conta a pagar.*/

            Console.WriteLine("Digite o codigo do item e a quantidade:");

            String[] valores = Console.ReadLine().Split(' ');

            int codigo = Convert.ToInt32(valores[0]);
            int qntd = Convert.ToInt32(valores[1]);

            double total;

            if (codigo == 1) {
                total = qntd * 4.0;
            }
            else if (codigo == 2) {

                total = qntd * 4.50;

            }
            else if (codigo == 3) {
                total = qntd * 5.00;

            }
            else if (codigo == 4) {
                total = qntd * 2.00;

            }
            else {
                total = qntd * 1.50;
            }

            Console.WriteLine("Total: R$ " + total);

        }
    }
}
