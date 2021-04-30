using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using solucionIoT.COMMON.Validadores;
using SolucionIoT.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolucionIoT.BIZ
{
    public static class FactoryManager
    {
        public static IUsuarioManager UsuarioManager() 
        {
            return new UsuarioManager(new GenericRepository<Usuario>(new UsuarioValidator()));
        }
        public static IAccionManager AccionManager() 
        {
            return new AccionManager(new GenericRepository<Accion>(new AccionValidator()));
        }
        public static ILecturaManager LecturaManager()
        {
            return new LecturaManager(new GenericRepository<Lectura>(new LecturaValidator()));
        }
        public static IDispositivoManager DispositivoManager() 
        {
            return new DispositivoManager(new GenericRepository<Dispositivo>(new DispositivoValidator()), new GenericRepository<Usuario>(new UsuarioValidator()));
        }
    }
}
