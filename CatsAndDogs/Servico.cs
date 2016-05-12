using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatsAndDogs
{
    class Servico
    {
        private string _servico;

        public string servico
        {
            get { return _servico; }
            set { _servico = value; }
        }

        private float _valor;

        public float valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private string _status;

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }

    }
}
