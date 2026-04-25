using FixTintas.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{
    public class ProdutoServico
    {
        public List<Produto> lista = new List<Produto>();
        private int contadorId = 1;

        public void Adicionar(Produto produto)
        {          

            if (produto.Fornecedor == null)
            {
                Console.WriteLine("Produto precisa de um fornecedor !");
                return;
            }
            
            if(produto.Preco < 0)
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
                Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Preço: {p.Preco} | Fornecedor: {p.Fornecedor.Nome}");
            }
        }
    }
}


// to achando que estou viagendo demaais no projeto ... professor pediu um esqueleto eu ja meio que criei uma
// tela no prompt ... acho que vou atualizar isso ... 