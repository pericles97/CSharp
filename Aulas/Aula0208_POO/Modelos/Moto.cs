using System;

namespace Aula0208_POO.Modelos {
    class Moto : Veiculo, IMotorizado {

        public int Velocidade { get; set; }

        public void Acelerar() {
            Console.WriteLine("Pisando no acelerador...");
            Velocidade += 5;
        }

        public void Frenar() {
            Console.WriteLine("Pisando no freio...");
            Velocidade -= 5;
        }
    }
}
