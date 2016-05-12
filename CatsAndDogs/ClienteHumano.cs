using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatsAndDogs
{
    class ClienteHumano : ClienteBase
    {
        private string _endereco;

        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _telefone;

        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

    }
}
