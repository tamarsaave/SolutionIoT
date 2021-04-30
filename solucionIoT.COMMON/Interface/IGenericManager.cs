using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Interface
{
    public interface IGenericManager<T> where T:BaseDTO 
    {
        string Error { get; }
        IEnumerable<T> ObtenerTodo { get; }
        T Insertar(T entidad);
        T Actualizar(T entidad);
        bool Eliminar(string id);
        T BuscarPorId(string id);
    }
}
