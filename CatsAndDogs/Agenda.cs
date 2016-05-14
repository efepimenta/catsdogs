using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatsAndDogs
{
    class Agenda
    {

        private ClienteHumano _cliente;

        public ClienteHumano cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private ClienteAnimal _animal;

        public ClienteAnimal animal
        {
            get { return _animal; }
            set { _animal = value; }
        }

        private DateTime _data;

        public DateTime data
        {
            get { return _data; }
            set { _data = value; }
        }

        private DateTime _hora;

        public DateTime hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        private Funcionario _functionario;

        public Funcionario funcionario
        {
            get { return _functionario; }
            set { _functionario = value; }
        }

        private Servico _servico;

        public Servico servico
        {
            get { return _servico; }
            set { _servico = value; }
        }


    }
}
