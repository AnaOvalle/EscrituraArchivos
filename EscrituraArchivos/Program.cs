using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de la matriz
            string[] lines = new string[1];
            // declaración de la variable
            string n;

            // captura del nombre
            Console.WriteLine("Ingrese nombre: ");
            n = Console.ReadLine();

            // asignacion
            lines[0] = n;
            

            using (StreamWriter sx = new StreamWriter("archivo.txt"))
            {
                for (int e = 0; e < lines.Length; e++)
                {
                    sx.WriteLine(lines[e]);
                }
                sx.Close();
                Console.WriteLine("Escribiendo el archivo...");
                Console.ReadLine();
            }

                
        }
    }
}
