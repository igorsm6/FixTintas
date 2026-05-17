using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{    
    // Interface genérica utilizada como "contrato"
    // O <T> representa um tipo genérico, permitindo reutilizar
    // a interface em diferentes entidades do sistema.
    // Toda classe de serviço deve implementar os métodos abaixo.
    public interface IService<T>                       
    {                            
        void Adicionar(T obj);
        void Listar();
    }
}