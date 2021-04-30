using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Interface
{
     public interface IAccionManager:IGenericManager<Accion>
    {
        IEnumerable<Accion> AccionDelDispositivo(string id);
        IEnumerable<Accion> AccionDelDispositivo(string id, DateTime inicio, DateTime fin);
        IEnumerable<Accion> AccionDelDispositivo(string id, string actuador, DateTime inicio, DateTime fin);
     } 
}

