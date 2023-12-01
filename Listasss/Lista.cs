using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listasss
{
    class Lista
    {
        private Nodo _primero;
        private Nodo _ultimo;

        public Lista()
        {
            _primero = null;
            _ultimo = null;
        }
        public bool ListaVacia()
        {
            return _primero == null ? true : false;
        }

        public void IngresarEnLista(Persona personaIngresada)
        {
            Nodo Nuevo;
            Nuevo = new Nodo(personaIngresada);
            if (ListaVacia())
            {
                _primero = Nuevo;
                _ultimo = Nuevo;
            }
            else
            {
                _ultimo.Siguiete = Nuevo;
                _ultimo = Nuevo;
            }
        }

        public int CantidadDeElementosEnLista()
        {
            if (ListaVacia())
                return -1;
            else
            {
                Nodo Auxiliar = _primero;
                int contador = 1;
                while(Auxiliar.Siguiete != null)
                {
                    contador++;
                    Auxiliar = Auxiliar.Siguiete;
                }
                return contador;
            }
        }

        public void OrdenarPorEdad()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La Lista Se Encuentra Vacia");   
            }
            else
            {
                int enLista = CantidadDeElementosEnLista();
                if(enLista < 2)
                {
                    Console.WriteLine($"Unicamente se encuentra la persona: {_primero.Persona.Nombre} en lista!");
                }
                else
                {
                    Nodo Auxiliar = _primero;
                    Persona[] arregloTemporal = new Persona[enLista];
                    Persona temporal = new Persona();
                    for(int i = 0; i < enLista; i++)
                    {
                        arregloTemporal[i] = Auxiliar.Persona;
                        Auxiliar = Auxiliar.Siguiete;
                    }
                    for (int i = 0; i < enLista - 1; i++)
                    {
                        for (int j = 0; j < enLista - i - 1; j++)
                        {
                            if (arregloTemporal[j].Edad > arregloTemporal[j + 1].Edad)
                            {
                                // Intercambio de personas
                                temporal = arregloTemporal[j];
                                arregloTemporal[j] = arregloTemporal[j + 1];
                                arregloTemporal[j + 1] = temporal;
                            }
                        }
                    }
                    _primero = null;
                    _ultimo = null;
                    for(int i = 0; i < enLista; i++)
                    {
                        IngresarEnLista(arregloTemporal[i]);
                    }
                }
            }
        }
        public void Listar()
        {
            if (ListaVacia())
            {
                Console.WriteLine("La Lista Se Encuentra Vacía");
            }
            else
            {
                Nodo Auxiliar = _primero;
                int contador = 1;
                while (Auxiliar.Siguiete != null)
                {
                    Console.WriteLine($"No.{contador} Nombre: {Auxiliar.Persona.Nombre}, Edad: {Auxiliar.Persona.Edad}");
                    contador++;
                    Auxiliar = Auxiliar.Siguiete;
                }
                Console.WriteLine($"No.{contador} Nombre: {Auxiliar.Persona.Nombre}, Edad: {Auxiliar.Persona.Edad}");
            }
        }
    }
}
