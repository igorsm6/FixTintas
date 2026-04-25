using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Fornecedor : Entidades
    {
        public string CNPJ { get; set; }

        public override void Exibir()
        {
            Console.WriteLine($"Fornecedor: {Nome} | CNPJ: {CNPJ}");
        }

    }
}
