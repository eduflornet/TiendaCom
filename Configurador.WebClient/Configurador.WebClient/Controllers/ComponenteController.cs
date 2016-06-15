using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseServicios;
using Configurador.Repositorio.Model;
using Configurador.WebClient.Models;
using Microsoft.Practices.Unity;

namespace Configurador.WebClient.Controllers
{
    public class ComponenteController : Controller
    {
        public int PageSize = 4;

        [Dependency]
        public IServiciosRest<Componente> Servicio { get; set; }

        public ViewResult List(int idCategoria = 1, int page = 1)
        {

            ComponenteListViewModel viewModel = new ComponenteListViewModel
            {
                Componentes = Servicio.Get().Where(p => p.idCategoria == idCategoria)
                    .OrderBy(p => p.Id)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = idCategoria == 0 ?
                        Servicio.Get().Count() :
                        Servicio.Get().Count(e => e.idCategoria == idCategoria)
                },
                CurrentCategory = idCategoria
            };
            return View(viewModel);
        }

        public ActionResult GetImage(int id)
        {
            throw new NotImplementedException();
        }
    }
}