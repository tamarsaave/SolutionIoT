using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolucionIoT.BIZ
{
    public class DispositivoManager : GenericManager<Dispositivo>, IDispositivoManager
    {
        IGenericRepository<Usuario> usuarioRepository;
        public DispositivoManager(IGenericRepository<Dispositivo> repository, IGenericRepository<Usuario> usuarioRepository) : base(repository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public bool DispositivoPerteneceAUsuario(string idDispositivo, string idUsuario)
        {
            return repository.Query(d => d.Id == idDispositivo && d.IdUsuario == idUsuario).Count() == 1;
        }

        public IEnumerable<Dispositivo> DispositivosDeUsuario(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dispositivo> DispositivosDeUsuarioPorEmail(string email)
        {
            Usuario user = usuarioRepository.Query(u => u.Correo == email).SingleOrDefault();
            return DispositivosDeUsuarioPorId(user.Id);
        }

        private IEnumerable<Dispositivo> DispositivosDeUsuarioPorId(string id)
        {
            return repository.Query(u => u.Id == id);
        }

        IEnumerable<Dispositivo> IDispositivoManager.DispositivosDeUsuarioPorId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
