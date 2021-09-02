using System;
using System.Globalization;


namespace exercicio4_estrutura_sequencial {
    class Program {
        static void Main(string[] args) {

            int func, horasTrab;
            double valorHora, salario;

            Console.WriteLine("Numero do funcionario:");
            func = int.Parse(Console.ReadLine());

            Console.WriteLine("Horas trabalhadas:");
            horasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor por hora trabalhada:");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario =  horasTrab * valorHora;

            Console.WriteLine("Numero do funcionario: " + func);
            Console.WriteLine("Salario: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
            


        }
    }
}
