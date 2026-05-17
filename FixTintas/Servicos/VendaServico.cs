using FixTintas.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{
    public class VendaServico : IService<Venda>
    {
        public List<Venda> lista = new List<Venda>();

        private int contadorId = 1;

        public void Adicionar(Venda venda)
        {
            venda.Id = contadorId;
            contadorId++;

            lista.Add(venda);

            Console.WriteLine("Venda cadastrada!");
        }

        public void Listar()
        {
            foreach (var v in lista)
            {
                Console.WriteLine($"ID: {v.Id} | Cliente: {v.Cliente.Nome} | Valor: {v.ValorTotal}");
            }
        }
    }
}
