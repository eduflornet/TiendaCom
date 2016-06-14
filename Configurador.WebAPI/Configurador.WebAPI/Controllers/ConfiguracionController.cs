using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BaseRepositorio.Repositorio;
using Configurador.Repositorio.Model;
using Configurador.Repositorio.ViewModel;
using Microsoft.Practices.Unity;

namespace Configurador.WebAPI.Controllers
{
    public class ConfiguracionController : ApiController
    {
        [Dependency] 
        public IRepositorio<Configuracion, ConfiguracionViewModel> Repositorio { get; set; }


        [HttpPost]
        [ResponseType(typeof(ConfiguracionViewModel))]
        public IHttpActionResult NuevaConfiguracion(ConfiguracionViewModel model)
        {
            var data = Repositorio.Add(model);
            if (data == null)
            {
                return BadRequest("Error al crear el objeto");
            }

            return Created("ConfiguradorWebAPI", data);

        }
    }
}
