using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Metodo
{
    internal class Moeda
    {   
        //Converter real para dolar
        public static void ConversaoDolar()
        {
            Console.WriteLine("Digite seu valor em real");
            double n1 = Convert.ToDouble(Console.ReadLine());

            double n2 = n1 / 4.91;
            Console.WriteLine(n2);
        }

        //Converter Dolar para Real
        public static void ConversaoReal() 
        {
            Console.WriteLine("Digite seu valor em dolar");
            double n1 = Convert.ToDouble(Console.ReadLine());

            double n2 = n1 * 4.91;
            Console.WriteLine(n2);
        }

        //Converter Real em Euro

        public static void ConversaoEuro()
        {
            Console.WriteLine("Digite seu valor em real");
            double n1 = Convert.ToDouble(Console.ReadLine());

            double n2 = n1 * 5.38;
            Console.WriteLine(n2);
        }
    }
}
