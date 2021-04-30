using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Interface
{
     public interface IDispositivoManager:IGenericManager<Dispositivo>
    {
        IEnumerable<Dispositivo> DispositivosDeUsuarioPorId(string id);
        IEnumerable<Dispositivo> DispositivosDeUsuarioPorEmail(string email);
        bool DispositivoPerteneceAUsuario(string idDispositivo, string idUsuario);
    }
}
