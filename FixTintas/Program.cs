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
            // ====================== NA PASTA MODELOS ====================== //

            // CLIENTE

            ClienteServico clienteServico = new ClienteServico();

            Cliente cliente = new Cliente
            {
                Nome = "Igor",
                CPF = "123.456.789-00"
            };
            cliente.Exibir();
            clienteServico.Adicionar(cliente);

          
            // FORNECEDOR

            FornecedorServico fornecedorServico = new FornecedorServico();

            Fornecedor fornecedor = new Fornecedor
            {
                Nome = "Coral",
                CNPJ = "00.000.000/0000-00"
            };
            fornecedor.Exibir();
            fornecedorServico.Adicionar(fornecedor);


           
            // PRODUTO
            // (ligado ao fornecedor)
         
            ProdutoServico produtoServico = new ProdutoServico();

            Produto produto = new Produto
            {
                Nome = "Tinta Azul",
                Preco = 150,
                Fornecedor = fornecedor
            };

            produtoServico.Adicionar(produto);


            /* alguns esclarecimento, a pasta servicos serve para guardar dados em listagens 
             * para num futuro proximo quando nossas agendas se trobarem eles conectam com o banco de dados
             * na pasta serviços temos cadastrar, atualizar, remover, buscar, ENTÂO a pasta serviços é ...
             * os serviços kkkkkkkk

            /* ja a pasta Modelos serve para as coisas do mundo real, por isso instaciamos elas
             * Cada classe representa uma entidade real e por enquanto só passamos propriedades(atributos)
             * aqui a gente vai só salvar dados, dados de clientes,produtos,fornecedor e coisas futuras
      
            // LISTAGEM
           
            /* pensei em colocar só visualmente essa listagem mas por enquanto
             * vou deiar ela assim como comentario, só caso a gente queria ver se o programa
             * esta funciondo certinho. bjs GordãoDoPc

           /* Console.WriteLine("\n--- CLIENTES ---");
            clienteServico.Listar();

            Console.WriteLine("\n--- FORNECEDORES ---");
            fornecedorServico.Listar();

            Console.WriteLine("\n--- PRODUTOS ---");
            produtoServico.Listar();

            Console.ReadLine(); */
        }
    }
}