using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Interface
{
    public interface ILecturaManager:IGenericManager<Lectura>
    {
        IEnumerable<Lectura> LecturasDelDispositivo(string id);
        IEnumerable<Lectura> LecturasDelDispositivo(string id, DateTime inicio,DateTime fin);
    }
}
