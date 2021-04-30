using Microsoft.AspNetCore.Mvc;
using solucionIoT.COMMON.Entidades;
using solucionIoT.COMMON.Interface;
using SolucionIoT.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SolucionIoT.Web.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngresaDatosController : ControllerBase
    {
        IUsuarioManager usuarioManager;
        IDispositivoManager dispositivoManager;
        ILecturaManager lecturaManager;
        IAccionManager accionManager;
        public IngresaDatosController()
        {
            usuarioManager = FactoryManager.UsuarioManager();
            dispositivoManager = FactoryManager.DispositivoManager();
            lecturaManager = FactoryManager.LecturaManager();
            accionManager = FactoryManager.AccionManager();
        }
        [HttpPut]
        public ActionResult<Accion> Put(string correo, string password, string idDisposotivo, string actuador, bool estado) 
        {
            Usuario u = usuarioManager.Login(correo, password);
            if (u != null)
            {
                if (dispositivoManager.DispositivoPerteneceAUsuario(idDisposotivo, u.Id))
                {
                    try
                    {
                        return Ok(accionManager.Insertar(new Accion()
                        {
                            Actuador=actuador,
                            Estado=estado,
                            IdDispositivo=idDisposotivo
                        }));
                    }
                    catch (Exception)
                    {
                        return BadRequest("No se pudo crear la Accion" + lecturaManager.Error);
                    }
                }
                else
                {
                    return BadRequest("dispositivo no pertenece al usuario... ");

                }
            }
            else
            {
                return BadRequest("usuario y/o contraseña incorrecta... ");
            }

        }

        // POST api/<IngresaDatosController>
        [HttpPost]
        public ActionResult<Lectura> Post(string correo,string password, string idDispositivo,float temperatura, float humedad, float luminosidad)
        {
            Usuario u = usuarioManager.Login(correo, password);
            if (u != null)
            {
                if (dispositivoManager.DispositivoPerteneceAUsuario( idDispositivo, u.Id))
                {
                    try
                    {
                        return Ok(lecturaManager.Insertar(new Lectura()
                        {
                            Humedad = humedad,
                            IdDispositivo=idDispositivo,
                            Luminosidad=luminosidad,
                            Temperatura=temperatura
                        })) ;
                    }
                    catch (Exception)
                    {
                        return BadRequest("No se pudo crear la lectura" + lecturaManager.Error);
                    }
                }
                else
                {
                    return BadRequest("dispositivo no pertenece al usuario... ");

                }
            }
            else 
            {
                return BadRequest("usuario y/o contraseña incorrecta... ");
            }
        }
 
    }
}
