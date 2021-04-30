using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using SolucionIoT.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionIoT.Web.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : GenericAPIController<Usuario>
    {
        public UsuarioController() : base(FactoryManager.UsuarioManager())
        {
        }
    }
}
