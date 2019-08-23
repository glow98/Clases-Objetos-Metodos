using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)

        {
            Nombres n = new Nombres();
            Apellidos a = new Apellidos();
            Edades e = new Edades();

            n.Name();
            a.Apellido();
            e.Age();


        }
    }
}
