using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoCinaraLucasDaniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Astra = new Carro("Astra");
            Astra.Ligar();
            Astra.Mover();
            Astra.Abastecer();
            Astra.Mover();
            Console.ReadLine();
        }
    }
}
