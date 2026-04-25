using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco {  get; set; }

        // criei um namorinho aqui 
        public Fornecedor Fornecedor { get; set; }
    }
}
