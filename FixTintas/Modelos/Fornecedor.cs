using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{

    // Representa um fornecedor (empresa)
    // Também herda de Entidade
    public class Fornecedor : Entidade
    {
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        // Polimorfismo 
        public override void Exibir()
        {
            Console.WriteLine($"Fornecedor: {Nome} | CNPJ: {CNPJ}");
        }

    }
}
