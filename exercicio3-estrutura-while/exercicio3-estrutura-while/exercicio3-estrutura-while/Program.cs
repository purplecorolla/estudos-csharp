using System;

namespace exercicio3_estrutura_while {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insira o codigo do combustivel escolhido: ");

            int alcool = 0;
            int gas = 0;
            int diesel = 0;

            int tipo = Convert.ToInt32(Console.ReadLine());

            while (tipo != 4) {

                if (tipo == 1) {

                    alcool = alcool + 1;

                }
                else if (tipo == 2) {

                    gas = gas + 1;
                }
                else if (tipo == 3) {

                    diesel = diesel + 1;
                }
                else {
                    Console.WriteLine("Codigo Invalido, digite novamente: ");
                }


                tipo = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Clientes que abasteceram com alcool: " + alcool);
            Console.WriteLine("Clientes que abasteceram com gasolina: " + gas);
            Console.WriteLine("Clientes que abasteceram com diesel: " + diesel);
        }
    }
}
