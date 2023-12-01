using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listasss
{
    public class Nodo
    {
        private Nodo _siguiente;
        private Persona _persona;

        public Nodo Siguiete
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Persona Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }
        public Nodo()
        {
            _siguiente = null;
            _persona = null;
        }
        public Nodo(Persona personaIngresada)
        {
            _siguiente = null;
            _persona = personaIngresada;
        }
        public Nodo(Persona personaIngresada, Nodo siguiente)
        {
            _siguiente = siguiente;
            _persona = personaIngresada;
        }
    }
}
