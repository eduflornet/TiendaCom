using Configurador.WebClient.Models;

namespace Configurador.WebClient.Domain.Abstract
{
    
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }

}