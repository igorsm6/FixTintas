using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
    public class Entidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}
