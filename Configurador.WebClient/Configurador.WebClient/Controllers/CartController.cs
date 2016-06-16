using System.Linq;
using System.Web.Mvc;
using BaseServicios;
using Configurador.Repositorio.Model;
using Configurador.WebClient.Domain.Abstract;
using Configurador.WebClient.Models;
using Microsoft.Practices.Unity;

namespace Configurador.WebClient.Controllers
{
    public class CartController : Controller
    {
        [Dependency]
        public IServiciosRest<Componente> Servicio { get; set; }
        private IOrderProcessor orderProcessor;
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Lo sentimos tu carrito esta vacio!");
            }

            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }
        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        public RedirectToRouteResult AddToCart(Cart cart, string returnUrl, int idComponente = 1)
        {
            Componente componente = Servicio.Get()
                .FirstOrDefault(c => c.Id == idComponente);

            if (componente != null)
            {
                cart.AddItem(componente, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int idComponente, string returnUrl)
        {
            Componente componente = Servicio.Get()
                .FirstOrDefault(c => c.Id == idComponente);

            if (componente != null)
            {
                cart.RemoveLine(componente);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}