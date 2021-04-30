using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolucionIoT.BIZ
{
    public class UsuarioManager : GenericManager<Usuario>, IUsuarioManager
    {
        public UsuarioManager(IGenericRepository<Usuario> repository) : base(repository)
        {
        }

        public Usuario Login(string email, string password)
        {
            return repository.Query(u => u.Correo == email && u.Password == password).ToList().SingleOrDefault();
        }

        public Usuario Login(string password)
        {
            throw new NotImplementedException();
        }
    }
}
