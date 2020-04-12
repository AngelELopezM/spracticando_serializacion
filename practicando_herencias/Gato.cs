using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace practicando_herencias
{
    [Serializable]
    public class Gato
    {
        public string nombre { set; get; }
        public string apellido { set; get; }
        public int edad { set; get; }


       public void C_gato(string nom, string ape, int eda)
        {
            nombre = nom;
            apellido = ape;
            edad = eda;
        }
    }
}
