using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Serialization
{
    [Serializable]
    public class Persona
    {
        private string Name;
        private string Surname;
        private int Age;

        public Persona(string Name, string Surname, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
    }
}
