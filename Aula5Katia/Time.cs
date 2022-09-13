using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5Katia
{
    internal class Time
    { 
        // Construtores

        public Time()
        {
            Nome = "Atibaia FC";
            Pais = "Brasi";
            Estado = "São Paulo";
            Titulo = 0;
        }

        public Time (string p, string e)
        {
            Pais = p;
            Estado = e;
        }
        public string Nome { get; set; }

        public string Pais { get; set; }
        public string Estado { get; set; }  
        public int Titulo { get; set; }
    }
}
