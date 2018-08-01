using System;

namespace Aula3127_Console {
    class Program {
        public static int Id { get; set; }

        static void Main(string[] args) {
            Console.WriteLine("Hellou World!!");

            //Console.ReadKey();

            Console.Write("Digite um número: ");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + Id);

            Console.ReadKey();
        }
    }
}
