using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Cliente : Entidades
    {
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }


        public override void Exibir()
        {
            Console.WriteLine($"Cliente: {Nome} | CPF: {CPF}");
        }

    }
}
