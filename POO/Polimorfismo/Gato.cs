using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    class Gato : Animal
    {
        public override void Correr()
        {
            Console.WriteLine("O gato está correndo");
        }
        public override void Comer()
        {
            Console.WriteLine("O gato está comendo ração");
        }
    }
}
