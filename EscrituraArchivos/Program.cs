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
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            // si el archivo no existe creará el elemento o archivo
            // si ya existe escribirá en el.
            // true es para agregar y no para sobrescribir

            // crear un arreglo 
            string[] lines =
            {
                "Esta es la información de la primera línea",
                "Esta es la segunda línea",
                "fin del texto"
            };

            // Recorre el arreglo
            foreach  (string line in lines)
            {
                sw.WriteLine(line); //Escribe el archivo
            }
            sw.Close();

            Console.WriteLine("Escribiendo el archivo...");
            Console.ReadLine();
                
        }
    }
}
