using FixTintas.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{

    //Classe ClienteServico, aqui nos vinculamos a classe cliente 
    //fazendo que todo tipo de alteração, cadastro, remoção etc seja ela a resposavel
    public class ClienteServico
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

        //será que faz sentido eu criar classes separadas ? bom qualquer coisas da para separar depois

        public void Listar()
        {
            //foreach ? ou for ? acho que foreach né tudo em uma linha
            //aqui eu criei o "cliente"

            foreach (var c in lista)
            {
                Console.WriteLine($"ID: {c.Id} | Nome: {c.Nome} | CPF: {c.CPF}");
            }
        }

        //faz sentido ter algo para atulizar ? acho que faz né

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

        //fiz o criar atualizar faz sentido o deletar né ?

        public void Remover(int id)
        {
            foreach (var c in lista)
            {
                if(c.Id == id)
                {
                    lista.Remove(c);
                    Console.WriteLine("Cliente Removido!");
                    return;
                }
            }

            Console.WriteLine("Cliente não encontrado!");
            //acho que é isso, vou vendo como vai ficar, vamos dar um commit ? opa claro
            // eu sei que esta dando erro fi, ja vou ver o que eu coloquei de errado papai
            // vou ver desses erroes ai 
            
        }

    }
}
