using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatsAndDogs
{
    class ClienteAnimal : ClienteBase
    {
        private char _tipo;

        public char tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _raca;

        public string raca
        {
            get { return _raca; }
            set { _raca = value; }
        }

        private char _sexo;

        public char sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        private ClienteHumano _cliente;

        public ClienteHumano cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

    }
}
