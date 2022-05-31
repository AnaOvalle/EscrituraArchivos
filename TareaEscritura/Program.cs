using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TareaEscritura
{
    class Program
    {
        class Hogwarts
        {
            // campos de la clase
            public string casa, nom, lema, grado;
            public int edad;

            // Constructor de la clase
            public Hogwarts(string casa, string nom, string lema, int edad, string grado)
            {
                this.casa = casa;
                this.nom = nom;
                this.lema = lema;
                this.edad = edad;
                this.grado = grado;
            }

        }

        static void Main(string[] args)
        {
            StreamWriter Hp = new StreamWriter("pergamino.txt", true); // crear el documento de texto

            // Declaración de las variables 
            string casa, nom, lema, grado;
            int edad;
            string contraseña;

            // captura de datos
            Console.WriteLine("----HOGWARTS----");
            Console.WriteLine("Registro Sala común\n");
            Console.Write("Ingrese la casa a la que pertenece: ");
            casa = Console.ReadLine();
            Console.Write("Ingrese su nombre: ");
            nom = Console.ReadLine();
            Console.Write("Ingrese el lema de su casa: ");
            lema = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = Int16.Parse(Console.ReadLine());
            Console.Write("Ingrese el grado a cursar: ");
            grado = Console.ReadLine();

            // objeto de la clase
            Hogwarts lumos = new Hogwarts(casa, nom, lema, edad, grado);

            // capturar contraseña           
            Console.Write("\nContraseña: ");
            contraseña = Console.ReadLine();
            // constraseñas de cada sala común.
            // Gryffindor: fortuna major
            // Slytherin: sangre pura
            // Hufflepuff: caput dragonis
            // Ravenclaw: el círculo no tiene principio

            Hp.WriteLine("Casa: " + lumos.casa);
            Hp.WriteLine("Nombre: " + lumos.nom);
            Hp.WriteLine("Lema: " + lumos.lema);
            Hp.WriteLine("Edad: " + lumos.edad);
            Hp.WriteLine("Grado a cursar: " + lumos.grado);


            if (contraseña == "fortuna major")
            {
                Hp.WriteLine("\nBienvenido a la sala común de Gryffindor");

            }

            if  (contraseña == "sangre pura")
            {
                Hp.WriteLine("\nBienvenido a la sala común de Slytherin");
            }

            if (contraseña == "caput dragonis")
            {
                Hp.WriteLine("\nBienvenido a la sala común de Hufflepuff");
            }

            if (contraseña == "el circulo no tiene principio")
            {
                Hp.WriteLine("\nBienvenido a la sala común de Ravenclaw");
            }

            else
            {
                Console.WriteLine("Contraseña incorrecta");
               
            }

            Hp.Close(); // cerrar el archivo

            Console.WriteLine("\nEscribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
