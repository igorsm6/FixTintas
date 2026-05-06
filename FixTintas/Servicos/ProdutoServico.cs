using FixTintas.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{
    // Serviço de produtos
    // Aqui temos algumas regras importantes do sistema
    // Classe ProdutoServico, aqui nos vinculamos com a classe produto 
    //fazendo que todo tipo de alteração, cadastro, remoção etc seja ela a resposavel

    public class ProdutoServico : IService<Produto>
    {
        public List<Produto> lista = new List<Produto>();
        private int contadorId = 1;

        public void Adicionar(Produto produto)
        {
            // produto precisa de fornecedor (regra de negócio)


            if (produto.Fornecedor == null)
            {
                Console.WriteLine("Produto precisa de um fornecedor !");
                return;
            }

            if (produto.Categoria == null)
            {
                Console.WriteLine("Produto precisa de uma categoria!");
                return;
            }

            if (produto.Preco < 0)
            {
                Console.WriteLine("Preço invalido ! ");
                return;
            }

            produto.Id = contadorId;
            contadorId++;
            lista.Add(produto);

            Console.WriteLine("Produto Cadastrado!");
        }

        public void Listar()
        {
            foreach (var p in lista)
            {
                Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Preço: {p.Preco} | Fornecedor: {p.Fornecedor.Nome} | Categoria: {p.Categoria.Nome}");
            }
        }
    }
}

 