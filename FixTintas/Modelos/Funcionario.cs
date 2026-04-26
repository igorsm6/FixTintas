using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Funcionario : Entidades
    {
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Contratado { get; set; }
    }
}
