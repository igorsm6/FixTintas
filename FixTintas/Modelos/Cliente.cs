using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Cliente : Entidade
    {
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        // essa parte não é necessariamente necessario kkkkkkk
        public override void Exibir()
        {
            Console.WriteLine($"Cliente: {Nome} | CPF: {CPF}");
        }

    }
}
