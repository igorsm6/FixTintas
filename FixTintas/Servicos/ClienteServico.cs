using FixTintas.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{
    // Serviço responsável por gerenciar clientes
    // Aqui fazemos o básico do CRUD (em memória por enquanto)
    //Classe ClienteServico, aqui nos vinculamos a classe cliente 
    //fazendo que todo tipo de alteração, cadastro, remoção etc seja ela a resposavel
    public class ClienteServico : IService<Cliente>
    {
        public List<Cliente> lista = new List<Cliente>();       

        private int contadorID = 1;

        //metodo adicionar cliente
        public void Adicionar(Cliente cliente)
        {
            if (cliente.Nome == "")
            {
                Console.WriteLine("Nome Invalido");
                return;  
            }

            if(cliente.CPF.Length != 11)
            {
                Console.WriteLine("CPF Invalido !");
                return;
            }

            cliente.Id = contadorID;
            contadorID++;

            lista.Add(cliente);

            Console.WriteLine("Cliente cadastrado!");
        }        

        public void Listar()
        {
            // percorre a lista e mostra cliente por cliente

            foreach (var c in lista)
            {
                Console.WriteLine($"ID: {c.Id} | Nome: {c.Nome} | CPF: {c.CPF}");
            }
        }
        
        public void Atualizar(int id, string novoNome, string novoCpf)
        {
            foreach(var c in lista)
            {
                if(c.Id == id)
                {
                    c.Nome = novoNome;
                    c.CPF = novoCpf;
                    Console.WriteLine("Cliente Atualizado !");
                    return;
                }
            }

            Console.WriteLine("Cliente não encontrado!");
        }       

        public void Remover(int id)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Id == id)
                {
                    lista.RemoveAt(i);
                    Console.WriteLine("Cliente Removido!");
                    return;
                }
            }

            Console.WriteLine("Cliente não encontrado!");           
            
        }

    }
}
