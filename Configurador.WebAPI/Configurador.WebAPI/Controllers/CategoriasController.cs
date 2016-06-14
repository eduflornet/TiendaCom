using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BaseRepositorio.Repositorio;
using Configurador.Repositorio.Model;
using Configurador.Repositorio.ViewModel;
using Microsoft.Practices.Unity;

namespace Configurador.WebAPI.Controllers
{
    public class CategoriasController : ApiController
    {
        [Dependency]
        public IRepositorio<Categoria, CategoriaViewModel> Repositorio { get; set; }

        public ICollection<CategoriaViewModel> Get()
        {
            return Repositorio.Get();
        }
    }
}
