using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatsAndDogs
{
    class Servico
    {
        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        private double _valor;

        public double valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private string _status = "";

        public void Iniciar()
        {
            this._status = "Em Execução";
        }

        public void Agendar()
        {
            this._status = "Agendado";
        }

        public void Concluir()
        {
            this._status = "Concluído";
        }

        public string getStatus()
        {
            return this._status;
        }

    }
}
