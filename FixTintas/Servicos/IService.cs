using System;
using System.Collections.Generic;
using System.Text;

namespace FixTintas.Servicos
{
    // Interface = "contrato"
    // todo serviço deve ter esses métodos
    public interface IService<T>
    {
        void Adicionar(T obj);
        void Listar();
    }
}