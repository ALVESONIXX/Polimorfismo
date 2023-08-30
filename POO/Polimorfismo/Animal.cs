using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
   
       class Animal
    {
         public string nome;
        public virtual void  Correr()
        {
            Console.WriteLine("O animal está correndo");

        }
        public virtual void Comer() 
        {
            Console.WriteLine("O animal está comendo");
        }
    }
}
