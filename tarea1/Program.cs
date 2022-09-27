using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor = "";
            int total = 0;
            int promedio = 0;

            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;
            int nota5 = 0;
            string nombre1 = "";
            string nombre2 = "";
            string nombre3 = "";
            string nombre4 = "";
            string nombre5 = "";



            Console.WriteLine("Ingrese el nombre de estudiante 1");
            nombre1 = Console.ReadLine();
            
            Console.WriteLine("Ingrese el nombre de estudiante 1");
            nombre2 = Console.ReadLine();
            
            Console.WriteLine("Ingrese el nombre de estudiante 1");
            nombre3 = Console.ReadLine();
            
            Console.WriteLine("Ingrese el nombre de estudiante 1");
            nombre4 = Console.ReadLine();
            
            Console.WriteLine("Ingrese el nombre de estudiante 1");
            nombre5 = Console.ReadLine();

            
            
            Console.WriteLine("Ingrese la calificación 1");
            valor = Console.ReadLine();
            nota1 = Convert.ToInt32(valor);

            Console.WriteLine("Ingrese la calificación 2");
            valor = Console.ReadLine();
            nota2 = Convert.ToInt32(valor);

            Console.WriteLine("Ingrese la calificación 3");
            valor = Console.ReadLine();
            nota3 = Convert.ToInt32(valor);

            Console.WriteLine("Ingrese la calificación 4");
            valor = Console.ReadLine();
            nota4 = Convert.ToInt32(valor);

            Console.WriteLine("Ingrese la calificación 5");
            valor = Console.ReadLine();
            nota5 = Convert.ToInt32(valor);



            total = nota1 + nota2 + nota3 + nota4 + nota5;
            promedio = total / 5;


            if (nota1 < promedio)
            {
                Console.WriteLine($"La nota de {nombre1} está por debajo del promedio");
            }
            else
            {
                Console.WriteLine($"La nota de {nombre1} está por encima del promedio");
            }
            if (nota2 < promedio)
            {
                Console.WriteLine($"La nota de {nombre2} está por debajo del promedio");
            }
            else
            {
                Console.WriteLine($"La nota de {nombre2} está por encima del promedio");
            }
            if (nota3 < promedio)
            {
                Console.WriteLine($"La nota de {nombre3} está por debajo del promedio");
            }
            else
            {
                Console.WriteLine($"La nota de {nombre3} está por encima del promedio");
            }
            if (nota4 < promedio)
            {
                Console.WriteLine($"La nota de {nombre4} está por debajo del promedio");
            }
            else
            {
                Console.WriteLine($"La nota de {nombre4} está por encima del promedio");
            }
            if (nota5 < promedio)
            {
                Console.WriteLine($"La nota de {nombre5} está por debajo del promedio");
            }
            else
            {
                Console.WriteLine($"La nota de {nombre5} está por encima del promedio");
            }

            // profe, sé que la intención de cómo conseguir el resultado era usando arreglos pero
            // el poco tiempo que he tenido para aprender la sintáxis de c# me está haciendo una mala pasada
            // Tampoco me alcanzó el tiempo (ni la mente) para sacar la nota más alta sin agregar 50 líneas más de código
            // estoy prácticando
            

        }
    }
}
