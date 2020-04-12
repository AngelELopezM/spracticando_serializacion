using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace practicando_herencias
{
    class Program
    {
        public static List<Gato> personas = new List<Gato>();
        
        static void Main(string[] args)
        {

            listado_personas();

        }

        public static void agregar_persona()
        {
            Console.Clear();
            Console.WriteLine("ingrese un nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese un apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("igrese la edad");
            int edad = Convert.ToInt32(Console.ReadLine());

            Gato insertar = new Gato();
            insertar.nombre = nombre;
            insertar.apellido = apellido;
            insertar.edad = edad;
            personas.Add(insertar);


            IFormatter formatter = new BinaryFormatter();
           Stream stream = new FileStream("C:\\Users\\enman\\OneDrive\\Escritorio\\C#\\practicando_herencias\\serializacion.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, personas);
            stream.Close();

            Console.WriteLine("finalizado");
            Console.ReadKey();
            
        }

        public static void listado_personas()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\enman\\OneDrive\\Escritorio\\C#\\practicando_herencias\\serializacion.txt", FileMode.Open, FileAccess.Read);
            
            Gato poner =  (Gato)formatter.Deserialize(stream);

            personas.Add(poner);
            Console.WriteLine(personas);

            Console.ReadKey();


        }
    }
}
