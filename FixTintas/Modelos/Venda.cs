using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Venda : Entidade
    {
        public Cliente Cliente { get; set; }

        public Funcionario Funcionario { get; set; }

        public DateTime DataVenda { get; set; }

        public string FormaPagamento { get; set; }

        public double ValorTotal { get; set; }
    }
}
