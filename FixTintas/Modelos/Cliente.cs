using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Cliente : Pessoa
    {
        public string CPF { get; set; }

        public override void Exibir()
        {
            Console.WriteLine($"Cliente: {Nome} | CPF: {CPF}");
        }

    }
}
