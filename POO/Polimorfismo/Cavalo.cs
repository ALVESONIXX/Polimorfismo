using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    class Cavalo : Animal
    {
        public override void Correr()
        {
            Console.WriteLine("O cavalo está correndo");
        }
        public override void Comer()
        {
            Console.WriteLine("O cavalo está comendo capim");
        }
    }
}
