using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos {
    class Barco : Veiculo, IMotorizado {

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
