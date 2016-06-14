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
    public class ComponentesController : ApiController
    {

        [Dependency] 
        public IRepositorio<Componente, ComponenteViewModel> Repositorio { get; set; }

        [Route("api/Componentes/")]
        public ICollection<ComponenteViewModel> Get()
        {
            return Repositorio.Get();
        }

        [Route("api/Componentes/{id}")]
        [ResponseType(typeof(ComponenteViewModel))] 
        public IHttpActionResult Get(int id)
        {
            var data = Repositorio.Get(id);

            if (data == null)
                return NotFound();

            return Ok(data);
        }
        
        [Route("api/ComponentesCategoria/{idCategoria}")]
        public ICollection<ComponenteViewModel> GetComponentesCategoria(int idCategoria)
        {
            return Repositorio.Get(o => o.idCategoria == idCategoria);
        }


    }
}
