using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Bytebank {
    class Program {
        static void Main(string[] args) {

            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Gabriela";
            conta.saldo = 200;


            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta.agencia);
            Console.WriteLine(conta.titular);

            Console.ReadLine();

        }
    }
}
