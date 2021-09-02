using System;
using System.Globalization;

namespace Exercicio {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

           byte idade = 30;
           int codigo = 5290;
           char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:\n{0}, cujo o preco e de ${1}\n{2}, cujo o preco é de ${3:F2}", produto1, preco1, produto2, preco2);
            Console.WriteLine($"Registro:\n{idade} anos de idade, codigo {codigo} e genero {genero}.");
            Console.WriteLine("Medida com oito numeros decimais: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            



        }
    }
}
