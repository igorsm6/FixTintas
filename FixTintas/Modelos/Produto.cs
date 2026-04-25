using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        // Criando uma relacionamento entre fornecedor e produto
        public Fornecedor Fornecedor { get; set; }


    }
}
