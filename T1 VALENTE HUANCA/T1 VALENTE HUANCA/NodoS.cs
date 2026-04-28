using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_VALENTE_HUANCA
{
    internal class NodoS
    {
        public NodoS(carros dato)
        {
            this.dato = dato;
            this.siguiente = null;
            this.anterior = null;
        }

        public carros dato { get; set; }
        public NodoS siguiente { get; set; }
        public NodoS anterior { get; set; }
            
    }
}
