using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartBeating
{
    public class produtos
    {
        private string _nomeProduto { get;set;}
        private string _tipoProduto { get;set;}
        private string _localEntrega { get;set;}
        private string _dia { get;set;}

        public override string ToString()
        {
            return _nomeProduto + " " + _tipoProduto;
        }

        public produtos(string Nome, string Tipo, string Local, string Dia)
        {
            this._nomeProduto = Nome;
            this._tipoProduto = Tipo;
            this._localEntrega = Local;
            this._dia = Dia;
        }
    }
}
