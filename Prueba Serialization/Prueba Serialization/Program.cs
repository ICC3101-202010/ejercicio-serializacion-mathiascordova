using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Prueba_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listPersona;

            void Almacenar(Persona persona)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("PerSave.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, persona);
                stream.Close();
            }
            void Cargar()
            {

            }
            

            while (true)
            {
                Console.WriteLine("1. Crear Persona" + Environment.NewLine + "2. Ver Personas" + Environment.NewLine + "x. Salir");
                string choice = Console.ReadLine();

                if (choice == "x"||choice == "X")
                {
                    Console.WriteLine("Bye");
                    break;
                }
                else if (choice == "1")
                {
                    Console.Write("Dame Nombre: ");
                    string Name = Console.ReadLine();
                    Console.Write("Dame Apellido: ");
                    string Surname = Console.ReadLine();
                    Console.Write("Dame Edad: ");
                    int Age = Int32.Parse(Console.ReadLine());
                    Persona per = new Persona(Name,Surname,Age);
                    
                }
            }

        }
    }
}
