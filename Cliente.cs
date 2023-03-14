using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barbero
{
    internal class Cliente
    {
        private int tiempo, key;
        Cliente sigCliente;
        public Cliente() { 
            sigCliente = null;
        }

        public Cliente(int tiempo) { 
            Tiempo = tiempo;
        }

        public int Tiempo {
            get { return tiempo; }
            set { tiempo = value; }
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public Cliente SigCliente
        {
            get { return sigCliente; }
            set { sigCliente = value; }
        }
    }
}
