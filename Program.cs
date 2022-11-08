using System;
using System.Threading.Tasks;

namespace U2AC1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido1;
            string grado, seccion;
            byte calificacion = 0;

            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido");
            apellido1 = Console.ReadLine();
            Console.WriteLine("Ingresa tu calificacion final");
            calificacion = Convert.ToByte(Console.ReadLine());

            if (calificacion >= 70)
            {
                Console.WriteLine("felicidades aprobaste el curso");

            }
            
              
              

              
            else
            {
                Console.WriteLine("Usted no aprobo el curso, tendra que recursar, nos vemos en la proxima");


            }
            
            


            Console.ReadKey();
        }
    }
}
