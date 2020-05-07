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
            List<Persona> listPersona = new List<Persona>();

            void Almacenar(List<Persona> persona)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("PerSave.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, persona);
                stream.Close();
            }
            void Cargar()
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("PerSave.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Persona> list = (List<Persona>)formatter.Deserialize(stream);
                stream.Close();
            }
            

            while (true)
            {
                Console.WriteLine("1. Crear Persona" + Environment.NewLine + "2. Ver Personas" + Environment.NewLine + "3. Cargar Personas" + Environment.NewLine + "x. Salir");
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
                    listPersona.Add(per);
                    
                }
                else if (choice == "2")
                {
                    for (int i = 0; i < listPersona.Count(); i++)
                    {
                        
                    }
                }
            }

        }
    }
}
