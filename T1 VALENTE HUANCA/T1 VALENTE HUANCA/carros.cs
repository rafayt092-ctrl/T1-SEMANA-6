using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_VALENTE_HUANCA
{
    internal class carros
    {
        public carros(string marca, int puertas, double ccmotor)
        {
            this.marca = marca;
            this.puertas = puertas;
            this.ccmotor = ccmotor;
        }
        public carros() { }

        public string marca { get; set; }
        public int puertas { get; set; }
        public double ccmotor { get; set; }
        
    }
}
