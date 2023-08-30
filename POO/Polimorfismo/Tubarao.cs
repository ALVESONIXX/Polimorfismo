using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    class Tubarao : Animal
    {
        public override void Correr()
        {
            Console.WriteLine("O tubarao está nadando"); 
        }
        public override void Comer()
        {
            Console.WriteLine("O tubarão está comendo peixes");
        }
    }
}
