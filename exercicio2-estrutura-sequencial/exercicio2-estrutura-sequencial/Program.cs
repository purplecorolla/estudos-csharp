using System;
using System.Globalization;

namespace exercicio2_estrutura_sequencial {
    class Program {
        static void Main(string[] args) {

            double raio, area, n = 3.14159;

            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            area = n * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
