using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionIoT.BIZ
{
    public class LecturaManager : GenericManager<Lectura>, ILecturaManager
    {
        public LecturaManager(IGenericRepository<Lectura> repository) : base(repository)
        {
        }

        public IEnumerable<Lectura> LecturasDelDispositivo(string id)
        {
            return repository.Query(l => l.IdDispositivo == id);

        }

        public IEnumerable<Lectura> LecturasDelDispositivo(string id, DateTime inicio, DateTime fin)
        {
            return repository.Query(l => l.IdDispositivo == id && l.FechaHora>=inicio && l.FechaHora<=fin);
        }
    }
}
