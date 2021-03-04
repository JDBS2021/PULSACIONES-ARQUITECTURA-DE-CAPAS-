using ENTIDAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionP3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, identificacion, sexo;
            int edad;
            

            Console.WriteLine("DIGITE LA IDENTIFICACION: ");
            identificacion = Console.ReadLine();


            Console.WriteLine("DIGITE EL NOMBRE: ");
            nombre = Console.ReadLine();


            Console.WriteLine("DIGITE EL SEXO : ");
            sexo = Console.ReadLine();


            Console.WriteLine("DIGITE LA EDAD: ");
            edad = int.Parse(Console.ReadLine());


            Persona persona = new Persona()
            {
                Identificacion = identificacion,
                Nombre = nombre,
                Sexo = sexo,
                Edad = edad,

            };

            persona.CalcularPulsacion();


            Console.WriteLine($"SU PULSACION ES {persona.Pulsacion}");

            Console.ReadKey();
        }
        

    }

}
}
