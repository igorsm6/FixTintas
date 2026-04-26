using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Estoque
    {
        public int Id { get; set; }      

        public int Quantidade { get; set; }
        public DateTime DataChegada { get; set; }

        // ligação com produto
        public Produto Produto { get; set; }
    }
}
