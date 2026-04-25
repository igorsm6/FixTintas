using System;
using System.Globalization;
using FixTintas.Modelos;
using FixTintas.Servicos;

namespace FixTintas
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteServico servico = new ClienteServico();

                  //criando fornecedor

            Fornecedor f = new Fornecedor();
            f.Nome = "Coral";
            f.CNPJ = "00.000.000/0000-00";

            // achei que fosse o nome, e para não ficar confuso instanciei com f, melhor

            FornecedorServico fornecedorServico = new FornecedorServico();

            fornecedorServico.Adicionar(f);

            //fazendo ligação do produto / fornecedor

            Produto produto = new Produto();
            produto.Nome = "Tinta Azul";
            produto.Preco = 150;
            produto.Fornecedor = f;

        }
    }
}