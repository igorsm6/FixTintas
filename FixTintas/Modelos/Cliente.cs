using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    // Representa um cliente do sistema
    // Herdando de Entidade pra reaproveitar Id e Nome
    public class Cliente : Entidade
    {
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }

        // aqui mostramos polimorfismo (cada classe exibe de um jeito)
        public override void Exibir()
        {
            Console.WriteLine($"Cliente: {Nome} | CPF: {CPF}");
        }

    }
}
