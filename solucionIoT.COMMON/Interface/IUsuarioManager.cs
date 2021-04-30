using solucionIoT.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace solucionIoT.COMMON.Interface
{
    public interface IUsuarioManager : IGenericManager<Usuario>
    {
        Usuario Login(string email, string password);
        Usuario Login(string password);
    }
}
