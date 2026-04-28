using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1_VALENTE_HUANCA
{
    internal class ListaEnlazadas
    {
        public NodoS prim { get; set; }
        public NodoS ulti { get; set; }
        public void AgregaDosCarros(string marca1, int puertas1, double ccmotor1, string marca2, int puertas2, double ccmotor2)
        {    
            carros carro1 = new carros(marca1, puertas1, ccmotor1);
            NodoS nuevoInicio = new NodoS(carro1);
            if (prim == null)
            {
                prim = nuevoInicio;
                ulti = nuevoInicio;
            }
            else
            {                
                nuevoInicio.siguiente = prim; 
                prim = nuevoInicio;
            }       
            carros carro2 = new carros(marca2, puertas2, ccmotor2);
            NodoS nuevoFin = new NodoS(carro2);
            if (prim == null)
            {
                prim = nuevoFin;
                ulti = nuevoFin;
            }
            else
            {               
                ulti.siguiente = nuevoFin; 
                ulti = nuevoFin;
            }
        }
        public override string ToString()
        {
            if (prim == null)
            {
                return "Esta vacia";
            }

            string resultado = "";
            NodoS actual = prim;
            int contador = 1;

            while (actual != null)
            {
                resultado += $"Carro {contador}: Marca: {actual.dato.marca}, Puertas: {actual.dato.puertas}, Cm^3 Motor: {actual.dato.ccmotor}\n";
                actual = actual.siguiente;
                contador++;
            }

            return resultado;
        }
        public ListaEnlazadas ListaSegunPuerta(int min, int max)
        {
            ListaEnlazadas listaRestringida = new ListaEnlazadas();
            NodoS actual = prim;

            while (actual != null)
            {
                if (actual.dato.puertas >= min && actual.dato.puertas <= max)
                {
                    NodoS nuevoNodo = new NodoS(actual.dato);

    
                    if (listaRestringida.prim == null)
                    {
                        listaRestringida.prim = nuevoNodo;
                        listaRestringida.ulti = nuevoNodo;
                    }
                    else
                    {
                        listaRestringida.ulti.siguiente = nuevoNodo;
                        listaRestringida.ulti = nuevoNodo;
                    }
                }

                actual = actual.siguiente;
            }

            return listaRestringida;
        }

        public void QuitaPenultimoCarro()
        {
            if (prim == null)
            {
                return;
            }
            if (prim == ulti)
            {
                prim = null;
                ulti = null;
                return;
            }          
            if (prim.siguiente == ulti)
            {
                prim = ulti; 
                return;
            }           
            NodoS actual = prim;
            while (actual.siguiente.siguiente != ulti)
            {
                actual = actual.siguiente;
            }


            actual.siguiente = ulti;
        }
        public ListaEnlazadas MezclaparImpar(ListaEnlazadas segunda)
        {
            ListaEnlazadas mezcla = new ListaEnlazadas();
            NodoS actual1 = this.prim;
            NodoS actual2 = null;
            if (segunda != null)
            {
                actual2 = segunda.prim;
            }
            int posicion = 1;
            while (actual1 != null || actual2 != null)
            {
                carros autoAgregar = null;
                if (posicion % 2 != 0)
                {
                    if (actual1 != null)
                    {
                        autoAgregar = actual1.dato;
                    }
                }
                else
                {
                    if (actual2 != null)
                    {
                        autoAgregar = actual2.dato;
                    }
                }
                if (autoAgregar != null)
                {
                    NodoS nuevoNodo = new NodoS(autoAgregar);

                    if (mezcla.prim == null)
                    {
                        mezcla.prim = nuevoNodo;
                        mezcla.ulti = nuevoNodo;
                    }
                    else
                    {
                        mezcla.ulti.siguiente = nuevoNodo;
                        mezcla.ulti = nuevoNodo;
                    }
                }

                if (actual1 != null) actual1 = actual1.siguiente;
                if (actual2 != null) actual2 = actual2.siguiente;

                posicion++;
            }
            return mezcla;
        }
    }
}
