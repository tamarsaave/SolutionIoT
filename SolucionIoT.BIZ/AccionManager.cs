using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionIoT.BIZ
{
    public class AccionManager : GenericManager<Accion>,IAccionManager
    {
        public AccionManager(IGenericRepository<Accion> repository) : base(repository)
        {
        }

        public IEnumerable<Accion> AccionDelDispositivo(string id)
        {
            return repository.Query(a => a.IdDispositivo == id);
        }

        public IEnumerable<Accion> AccionDelDispositivo(string id, DateTime inicio, DateTime fin)
        {
            return repository.Query(a => a.IdDispositivo == id && a.FechaHora >= inicio && a.FechaHora <= fin); 
        }

        public IEnumerable<Accion> AccionDelDispositivo(string id, string actuador, DateTime inicio, DateTime fin)
        {
            return repository.Query(a => a.IdDispositivo == id && a.Actuador == actuador && a.FechaHora >= inicio && a.FechaHora <= fin);
        }

        
    }
}
