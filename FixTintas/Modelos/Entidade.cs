using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Modelos
{
     /*
     * Classe base do sistema
     * Evita repetir Id e Nome nas outras classes
     * Cliente e Fornecedor herdam daqui 
     * Herança.
     */
    public abstract class Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // método que pode ser sobrescrito nas classes filhas (Polimorfismo)
        public virtual void Exibir()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    }
}
