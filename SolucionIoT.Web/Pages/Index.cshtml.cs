using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using solucionIoT.COMMON.Modelos;
using SolucionIoT.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolucionIoT.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Login Login { get; set; }
        [BindProperty]
        public bool EsLogin { get; set; }
        [BindProperty]
        public string Error { get; set; }

        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost() 
        {
            if (EsLogin)
            {
                IUsuarioManager usuarioManager = FactoryManager.UsuarioManager();
                Usuario u = usuarioManager.Login(Login.Correo,Login.Password);
                if (u != null)
                {
                    //mandar el panel del usuario
                    Error = $"Bienvenido{u.Nombre}!!!!!";
                }
                else
                {
                    Error = "Usuario y/o contaseña nicorrecto";//mandar un error
                }
            }
            else 
            {
                //mandar a crear un usuario
            }
        }
    }
}
