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
        public string Marca { get; set; }
        public string Cor {  get; set; }
        public DateTime DataChegada { get; set; }

        // Criando uma relacionamento entre fornecedor e produto
        public Fornecedor Fornecedor { get; set; }

        // criando um relaciomento entre Categoria e produto
        public Categoria Categoria { get; set; }

    }
}
