using System;

namespace Aula3127_Console {
    class Program {
        public static int num { get; set; }
        public static int num2 { get; set; }
        public static string operador { get; set; }

        static void Main(string[] args) {
            Console.WriteLine("Hellou World!!");

            //Console.ReadKey();

            Console.Write("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Digite um operador: ");
            operador = Console.ReadLine();

            Console.Write("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            if (operador == "+") {
                Console.WriteLine("A soma de " + num + " e " + num2 + " = " + (num + num2));
            }else if (operador == "/") {
                Console.WriteLine("A divisão de " + num + " e " + num2 + " = " + (num / num2));
            } else if (operador == "-") {
                Console.WriteLine("A subtração de " + num + " e " + num2 + " = " + (num - num2));
            } else if (operador == "*") {
                Console.WriteLine("A multiplicação de " + num + " e " + num2 + " = " + (num * num2));
            }
            
            //Console.WriteLine("Você digitou: " + Id);
            //ImprimirNumeroDigitado(Id);
            Console.ReadKey();
        }

        static void ImprimirNumeroDigitado(int num) {
            Console.WriteLine("Você digitou: " + num);
        }
    }
}
