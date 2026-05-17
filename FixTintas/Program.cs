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
            
            // CLIENTE

            // Ponto de entrada do sistema
            // Aqui só estamos testando a estrutura (rascunho)

            ClienteServico clienteServico = new ClienteServico();

            Cliente cliente = new Cliente
            {
                Nome = "Igor",
                CPF = "12345678900"
            };
            cliente.Exibir();
            clienteServico.Adicionar(cliente);

          
            // FORNECEDOR

            FornecedorServico fornecedorServico = new FornecedorServico();

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = "Coral",
                CNPJ = "00000000000000"
            };
            fornecedor.Exibir();
            fornecedorServico.Adicionar(fornecedor);


            //Categoria

            Categoria categoria = new Categoria
            {
                Nome = "Tinta de Parede"
            };          


            // PRODUTO
            // (ligado ao fornecedor)            

            ProdutoServico produtoServico = new ProdutoServico();

            Produto produto = new Produto
            {
                Nome = "Tinta Azul",
                Preco = 150,
                Fornecedor = fornecedor,
                Categoria = categoria
            };           

            produtoServico.Adicionar(produto);

            //FUNCIONARIO

            Funcionario funcionario = new Funcionario
            {
                Nome = "Carlos",
                CPF = "11111111111",
                Cargo = "Vendedor"
            };

            // VENDA

            VendaServico vendaServico = new VendaServico();

            Venda venda = new Venda
            {
                Cliente = cliente,
                Funcionario = funcionario,
                DataVenda = DateTime.Now,
                FormaPagamento = "PIX",
                ValorTotal = 150
            };

            vendaServico.Adicionar(venda);


            // teste para ver se esta tudo funcionando

            Console.WriteLine("\n--- CLIENTES ---");
            clienteServico.Listar();

            Console.WriteLine("\n--- FORNECEDORES ---");
            fornecedorServico.Listar();

            Console.WriteLine("\n--- PRODUTOS ---");
            produtoServico.Listar();

            Console.WriteLine("\n--- VENDAS ---");
            vendaServico.Listar();

            Console.WriteLine("\nSistema executado com sucesso!");
            Console.ReadLine();
        }
    }
}