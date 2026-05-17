using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class ItemVenda : Entidade
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double ValorUnitario { get; set; }

        public double Subtotal { get; set; }
    }
}
