using FixTintas.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{
    // Controle dos fornecedores (bem parecido com cliente)
    //Classe FornecedorServico, aqui nos vinculamos com a classe fornecedore 
    //fazendo que todo tipo de alteração, cadastro, remoção etc seja ela a resposavel
    public class FornecedorServico : IService<Fornecedor>
    {
        public List<Fornecedor> lista = new List<Fornecedor>();
        private int contadorId = 1;

        public void Adicionar(Fornecedor fornecedor)
        {
            if(fornecedor.Nome == "")
            {
                Console.WriteLine("Nome Invalido! ");
                return;
            }

            if(fornecedor.CNPJ.Length != 14)
            {
                Console.WriteLine("CNPJ Invalido");
                return;
            }

            fornecedor.Id = contadorId;
            contadorId++;

            lista.Add(fornecedor);

            Console.WriteLine("Fornecedor Cadastrado!");

        }


        // percorre a lista e mostra fornecedor por fornecedor
        public void Listar()
        {
            foreach (var f in lista)
            {
                Console.WriteLine($"ID: {f.Id} | Nome: {f.Nome} | CNPJ: {f.CNPJ} ");
            }
        }
    }
}
